using IdeaSystem.Data;
using IdeaSystem.Models;
using System.Collections.Generic;

namespace IdeaSystem.Services
{
    public class ManuallyTopicToTopicModel : IManuallyTopicToTopicModel
    {
        private ApplicationDbContext _context;
        public ManuallyTopicToTopicModel(ApplicationDbContext context)
        {
            _context = context;
        }


        public TopicModel TransferToTopicModel(string topicId)
        {
            var ideaQuery = from a in _context.TopicTable
                            join b in _context.IdeaTable on a.topic_Id equals b.idea_TopicId
                            join c in _context.ViewTable on b.idea_Id equals c.view_IdeadId
                            join d in _context.ReactTable on b.idea_Id equals d.react_IdeadId
                            where a.topic_Id == topicId
                            select new { a, b, c, d };
            var topicModel = new TopicModel();
            foreach (var topicItem in ideaQuery)
            {
                topicModel.topic_Id = topicItem.a.topic_Id;
                topicModel.topic_Name = topicItem.a.topic_Name;
                topicModel.idea_CreateOn = DateTime.Now; // 
                topicModel.topic_ClosureDate = topicItem.a.topic_ClosureDate;
                topicModel.topic_FinalClosureDate = topicItem.a.topic_FinalClosureDate;
                topicModel.topic_IsDelete = topicItem.a.topic_IsDelete;
                topicModel.ideaList = new List<IdeaDetailModel>();

                if (topicItem.a.ideaList != null)
                {
                    foreach (var ideaItem in topicItem.a.ideaList)
                    {
                        var ideaDetailModel = new IdeaDetailModel();
                        ideaDetailModel.idea_Id = ideaItem.idea_Id;
                        ideaDetailModel.idea_Text = ideaItem.idea_Text;
                        ideaDetailModel.idea_Name = ideaItem.idea_Name;
                        ideaDetailModel.idea_CreateOn = DateTime.Now; // 
                        ideaDetailModel.idea_FileName = ideaItem.idea_FileName;
                        ideaDetailModel.idea_UserId = ideaItem.idea_UserId;
                        //ideaDetailModel.idea_UserName = "";
                        ideaDetailModel.idea_TopicId = ideaItem.idea_TopicId;
                        //ideaDetailModel.idea_TopicName = "";
                        ideaDetailModel.idea_CategoryId = ideaItem.idea_CategoryId;
                        //ideaDetailModel.idea_CategoryName = "";
                        ideaDetailModel.viewList = new List<ViewModel>();
                        ideaDetailModel.reactList = new List<ReactModel>();
                        ideaDetailModel.commentList = new List<CommentModel>();

                        if (ideaItem.viewList != null)
                        {
                            // foreach for View
                            foreach (var viewItem in ideaItem.viewList)
                            {
                                var viewModel = new ViewModel();
                                viewModel.view_Id = viewItem.view_Id;
                                viewModel.view_VisitTime = viewItem.view_VisitTime;
                                viewModel.view_UserId = viewItem.view_UserId;
                                viewModel.view_IdeadId = viewItem.view_IdeadId;

                                ideaDetailModel.viewList.Add(viewModel);
                            }
                        }

                        if (ideaItem.reactList != null)
                        {
                            // foreach for React
                            foreach (var reactItem in ideaItem.reactList)
                            {
                                var reactModel = new ReactModel();
                                reactModel.react_Id = reactItem.react_IdeadId;
                                reactModel.react_React = reactItem.react_React;
                                reactModel.react_UserId = reactItem.react_UserId;
                                reactModel.react_IdeadId = reactItem.react_IdeadId;

                                ideaDetailModel.reactList.Add(reactModel);
                            }
                        }

                        if (ideaItem.commentList != null)
                        {
                            // foreach for Comment
                            foreach (var commentItem in ideaItem.commentList)
                            {
                                var commentModel = new CommentModel();
                                commentModel.cmt_Id = commentItem.cmt_Id;
                                commentModel.cmt_Text = commentItem.cmt_Text;
                                commentModel.cmt_Datetime = commentItem.cmt_Datetime;
                                commentModel.cmt_UserId = commentItem.cmt_UserId;
                                commentModel.cmt_IdeaId = commentItem.cmt_IdeaId;
                                commentModel.cmt_IsDelete = commentItem.cmt_IsDelete;

                                ideaDetailModel.commentList.Add(commentModel);
                            }
                        }
                        // Add
                        topicModel.ideaList.Add(ideaDetailModel);
                    }
                }
            }
            return topicModel;
        }


        public IdeaDetailModel TransferToIdeaDetailModel(string ideaId)
        {
            // Idea Query
            var ideaQuery = from a in _context.TopicTable
                            join b in _context.IdeaTable on a.topic_Id equals b.idea_TopicId
                            join c in _context.CategoryTable on b.idea_CategoryId equals c.category_Id
                            where (b.idea_Id == ideaId)
                            select new { a, b, c};

            IdeaDetailModel ideaDetailModel = new IdeaDetailModel();
            foreach (var ideaItem in ideaQuery)
            {
                ideaDetailModel.idea_Id = ideaItem.b.idea_Id;
                ideaDetailModel.idea_Text = ideaItem.b.idea_Text;
                ideaDetailModel.idea_FileName = ideaItem.b.idea_FileName;
                ideaDetailModel.idea_CreateOn = ideaItem.b.idea_DateTime;
                ideaDetailModel.idea_CategoryId = ideaItem.b.idea_CategoryId;
                ideaDetailModel.idea_UserId = ideaItem.b.idea_UserId;
                ideaDetailModel.idea_CategoryName = ideaItem.c.category_Name;
                ideaDetailModel.idea_TopicId = ideaItem.a.topic_Id;
                ideaDetailModel.idea_Name = ideaItem.b.idea_Name;

                ideaDetailModel.commentList = new List<CommentModel>();

                var commnetQuery = _context.CommentTable.Where(x => x.cmt_IdeaId == ideaItem.b.idea_Id);
                if (commnetQuery != null)
                {
                    foreach (var commentItem in commnetQuery)
                    {
                        CommentModel commentModel = new CommentModel();
                        commentModel.cmt_Id = commentItem.cmt_Id;
                        commentModel.cmt_Text = commentItem.cmt_Text;
                        commentModel.cmt_Datetime = commentItem.cmt_Datetime;
                        commentModel.cmt_IdeaId = commentItem.cmt_IdeaId;
                        commentModel.cmt_IsDelete = commentItem.cmt_IsDelete;

                        ideaDetailModel.commentList.Add(commentModel);
                    }
                }
            }
            return ideaDetailModel;
        }


        public List<IdeaDetailModel> TransferToIdeaDetailModelList(string topicId)
        {
            // Idea Query
            var ideaQuery = from a in _context.TopicTable
                            join b in _context.IdeaTable on a.topic_Id equals b.idea_TopicId
                            join c in _context.CategoryTable on b.idea_CategoryId equals c.category_Id
                            //join d in _context.ViewTable on b.idea_Id equals d.view_IdeadId
                            //join e in _context.ReactTable on b.idea_Id equals e.react_IdeadId
                            where (a.topic_Id == topicId)
                            select new { a, b, c};

            List<IdeaDetailModel> ideaDetailModelList = new List<IdeaDetailModel>();
            foreach (var ideaItem in ideaQuery)
            {
                IdeaDetailModel ideaDetailModel = new IdeaDetailModel();
                ideaDetailModel.idea_Id = ideaItem.b.idea_Id;
                ideaDetailModel.idea_Text = ideaItem.b.idea_Text;
                ideaDetailModel.idea_FileName = ideaItem.b.idea_FileName;
                ideaDetailModel.idea_CreateOn = ideaItem.b.idea_DateTime;
                ideaDetailModel.idea_CategoryId = ideaItem.b.idea_CategoryId;
                ideaDetailModel.idea_UserId = ideaItem.b.idea_UserId;
                ideaDetailModel.idea_CategoryName = ideaItem.c.category_Name;
                ideaDetailModel.idea_TopicId = ideaItem.a.topic_Id;
                ideaDetailModel.idea_Name = ideaItem.b.idea_Name;

                ideaDetailModel.commentList = new List<CommentModel>();

                ideaDetailModel.viewList = new List<ViewModel>();
                ideaDetailModel.reactList = new List<ReactModel>();
                ideaDetailModel.commentList = new List<CommentModel>();

                //if (ideaItem.b.viewList != null)
                //{
                //    // foreach for View
                //    foreach (var viewItem in ideaItem.b.viewList)
                //    {
                //        var viewModel = new ViewModel();
                //        viewModel.view_Id = viewItem.view_Id;
                //        viewModel.view_VisitTime = viewItem.view_VisitTime;
                //        viewModel.view_UserId = viewItem.view_UserId;
                //        viewModel.view_IdeadId = viewItem.view_IdeadId;

                //        ideaDetailModel.viewList.Add(viewModel);
                //    }
                //}

                //if (ideaItem.b.reactList != null)
                //{
                //    // foreach for React
                //    foreach (var reactItem in ideaItem.b.reactList)
                //    {
                //        var reactModel = new ReactModel();
                //        reactModel.react_Id = reactItem.react_IdeadId;
                //        reactModel.react_React = reactItem.react_React;
                //        reactModel.react_UserId = reactItem.react_UserId;
                //        reactModel.react_IdeadId = reactItem.react_IdeadId;

                //        ideaDetailModel.reactList.Add(reactModel);
                //    }
                //}

                ideaDetailModelList.Add(ideaDetailModel);   
            }
            return ideaDetailModelList;
        }

        public List<IdeaDetailModel> TransferToIdeaDetailModelList()
        {
            // Idea Query
            var ideaQuery = from a in _context.TopicTable
                            join b in _context.IdeaTable on a.topic_Id equals b.idea_TopicId
                            join d in _context.ViewTable on b.idea_Id equals d.view_IdeadId
                            join e in _context.ReactTable on b.idea_Id equals e.react_IdeadId
                            select new { a, b, d , e };

            List<IdeaDetailModel> ideaDetailModelList = new List<IdeaDetailModel>();
            foreach (var ideaItem in ideaQuery)
            {
                IdeaDetailModel ideaDetailModel = new IdeaDetailModel();
                ideaDetailModel.idea_Id = ideaItem.b.idea_Id;
                ideaDetailModel.idea_Text = ideaItem.b.idea_Text;
                ideaDetailModel.idea_FileName = ideaItem.b.idea_FileName;
                ideaDetailModel.idea_CreateOn = ideaItem.b.idea_DateTime;
                ideaDetailModel.idea_CategoryId = ideaItem.b.idea_CategoryId;
                ideaDetailModel.idea_UserId = ideaItem.b.idea_UserId;
                ideaDetailModel.idea_TopicId = ideaItem.a.topic_Id;
                ideaDetailModel.idea_Name = ideaItem.b.idea_Name;

                ideaDetailModel.commentList = new List<CommentModel>();

                ideaDetailModel.viewList = new List<ViewModel>();
                ideaDetailModel.reactList = new List<ReactModel>();
                ideaDetailModel.commentList = new List<CommentModel>();

                if (ideaItem.b.viewList != null)
                {
                    // foreach for View
                    foreach (var viewItem in ideaItem.b.viewList)
                    {
                        var viewModel = new ViewModel();
                        viewModel.view_Id = viewItem.view_Id;
                        viewModel.view_VisitTime = viewItem.view_VisitTime;
                        viewModel.view_UserId = viewItem.view_UserId;
                        viewModel.view_IdeadId = viewItem.view_IdeadId;

                        ideaDetailModel.viewList.Add(viewModel);
                    }
                }

                if (ideaItem.b.reactList != null)
                {
                    // foreach for React
                    foreach (var reactItem in ideaItem.b.reactList)
                    {
                        var reactModel = new ReactModel();
                        reactModel.react_Id = reactItem.react_IdeadId;
                        reactModel.react_React = reactItem.react_React;
                        reactModel.react_UserId = reactItem.react_UserId;
                        reactModel.react_IdeadId = reactItem.react_IdeadId;

                        ideaDetailModel.reactList.Add(reactModel);
                    }
                }

                ideaDetailModelList.Add(ideaDetailModel);
            }
            return ideaDetailModelList;
        }
    }
}
