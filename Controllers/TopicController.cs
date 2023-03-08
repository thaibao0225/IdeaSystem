using IdeaSystem.Data;
using IdeaSystem.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaSystem.Controllers
{
    public class TopicController : Controller
    {
        private ApplicationDbContext context;
        public TopicController(ApplicationDbContext _context)
        {
            context = _context;
        }

        // GET: TopicController
        [Route("/topic")]
        public ActionResult Index()
        {
            var query = context.TopicTable.Where(x => x.topic_IsDelete == false).ToList();


            return View(query);
        }

        // GET: TopicController/Details/5
        [Route("/topic/details")]
        public ActionResult Details(string id)
        {
            var query = context.TopicTable.FirstOrDefault(x => x.topic_Id == id);
            return View(query);
        }

        // GET: TopicController/Create
        [Route("/topic/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopicController/Create
        [HttpPost]
        [Route("/topic/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                string topicId = collection["topic_Id"];
                string topicName = collection["topic_Name"];
                string topicClosureDate = collection["topic_ClosureDate"];
                string topicFinalClosureDate = collection["topic_FinalClosureDate"];

                Topic topicCreate = new Topic()
                {
                    topic_Id = Guid.NewGuid().ToString(),
                    topic_Name = topicName,
                    topic_ClosureDate = DateTime.Parse(topicClosureDate),
                    topic_FinalClosureDate = DateTime.Parse(topicFinalClosureDate)
                };

                await context.TopicTable.AddAsync(topicCreate);

                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopicController/Edit/5
        [Route("/topic/edit")]
        public ActionResult Edit(string id)
        {
            var query = context.TopicTable.FirstOrDefault(x => x.topic_Id == id);
            return View(query);
        }

        // POST: TopicController/Edit/5
        [HttpPost]
        [Route("/topic/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {
                string topicId = collection["topic_Id"];
                string topicName = collection["topic_Name"];
                string topicClosureDate = collection["topic_ClosureDate"];
                string topicFinalClosureDate = collection["topic_FinalClosureDate"];

                var query = context.TopicTable.FirstOrDefault(x => x.topic_Id == topicId);

                if(query != null)
                {
                    query.topic_Name = topicName;
                    query.topic_ClosureDate = DateTime.Parse(topicClosureDate);
                    query.topic_FinalClosureDate = DateTime.Parse(topicFinalClosureDate);
                }

                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopicController/Delete/5
        [Route("/topic/delete")]
        public ActionResult Delete(string id)
        {
            var query = context.TopicTable.FirstOrDefault(x => x.topic_Id == id);
            return View(query);
        }

        // POST: TopicController/Delete/5
        [HttpPost]
        [Route("/topic/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {

                string topicId = collection["topic_Id"];

                var query = context.TopicTable.FirstOrDefault(x => x.topic_Id == topicId);

                if (query != null)
                {
                    query.topic_IsDelete = true;
                }

                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: TopicController/DetailsIdea/5
        [Route("/topic/detailsidea")]
        public ActionResult DetailsIdea(string id)
        {
            return View();
        }

        // POST: TopicController/DetailsIdea/5
        [HttpPost]
        [Route("/topic/detailsidea")]
        [ValidateAntiForgeryToken]
        public ActionResult DetailsIdea(string id, IFormCollection collection)
        {
            try
            {


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: TopicController/Like/5
        [Route("/topic/like")]
        public ActionResult Like(string id)
        {
            return View();
        }

        // POST: TopicController/Like/5
        [HttpPost]
        [Route("/topic/like")]
        [ValidateAntiForgeryToken]
        public ActionResult Like(string id, IFormCollection collection)
        {
            try
            {


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: TopicController/Like/5
        [Route("/topic/dislike")]
        public ActionResult Dislike(string id)
        {
            return View();
        }

        // POST: TopicController/Like/5
        [HttpPost]
        [Route("/topic/dislike")]
        [ValidateAntiForgeryToken]
        public ActionResult Dislike(string id, IFormCollection collection)
        {
            try
            {


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
