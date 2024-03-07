using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using StudentData1.DAL;
using StudentData1.Models;
using StudentData1.Models.DBEntities;

namespace StudentData1.Controllers
{
    public class StudentController1 : Controller
    {
        private readonly StudentDbContext _context;

        public StudentController1(StudentDbContext context)
        {
            this._context = context;

        }

        [HttpGet]
        public IActionResult Index()
        {
            var students= _context.Students.ToList();

			List<StudentViewModel> studentList = new List<StudentViewModel>();
			if (students != null)
            {
               
                foreach(var student in students)
                {
                    var StudentViewModel = new StudentViewModel()
                    {
                        Id = student.Id,
                        FirstName= student.FirstName,
                        LastName= student.LastName,
                        DateOfBirth= student.DateOfBirth,
                        Email= student.Email,
                        MobNO= student.MobNo

                    };
					studentList.Add(StudentViewModel);

				}
				return View(studentList);
			}

            return View(studentList);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(StudentViewModel studentData)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var student = new Student()
                    {
                        FirstName = studentData.FirstName,
                        LastName = studentData.LastName,
                        DateOfBirth = studentData.DateOfBirth,
                        Email = studentData.Email,
                        MobNo = studentData.MobNO

                    };

                    _context.Students.Add(student);
                    _context.SaveChanges();
                    TempData["successMessage"] = "Student added successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Model data is not valid";
                    return View();
                }
            }
            catch (Exception ex)
            {

                 TempData["errorMessage"] = ex.Message;
                return View();
            }
           
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            try
            {
                var student = _context.Students.SingleOrDefault(x => x.Id == Id);
                if (student != null)
                {
                    var studentView = new StudentViewModel()
                    {
                        Id = student.Id,
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        DateOfBirth = student.DateOfBirth,
                        Email = student.Email,
                        MobNO = student.MobNo

                    };
                    return View(studentView);
                }
                else
                {
                    TempData["erroMessage"] = $"Student details is not available with Id: {Id} ";
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                TempData["errorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Edit(StudentViewModel model) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var student = new Student()
                    {
                        Id = model.Id,
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        DateOfBirth = model.DateOfBirth,
                        Email = model.Email,
                        MobNo = model.MobNO
                    };
                    _context.Students.Update(student);
                    _context.SaveChanges();
                    TempData["successMessage"] = "Student Details Updated successfully!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "model data is invalid";
					return View();
				}
            }
            catch (Exception ex)
            {
				TempData["errorMessage"] = ex.Message;
				return View();
			}
           
        }


		[HttpGet]
		public IActionResult Delete(int Id)
		{
			try
			{
				var student = _context.Students.SingleOrDefault(x => x.Id == Id);
				if (student != null)
				{
					var studentView = new StudentViewModel()
					{
						Id = student.Id,
						FirstName = student.FirstName,
						LastName = student.LastName,
						DateOfBirth = student.DateOfBirth,
						Email = student.Email,
						MobNO = student.MobNo

					};
					return View(studentView);
				}
				else
				{
					TempData["erroMessage"] = $"Student details is not available with Id: {Id} ";
					return RedirectToAction("Index");
				}

			}
			catch (Exception ex)
			{
				TempData["errorMessage"] = ex.Message;
				return RedirectToAction("Index");
			}
		}
        [HttpPost]
        public IActionResult Delete(StudentViewModel model)
        {
            try
            {
                var student = _context.Students.SingleOrDefault(x => x.Id == model.Id);
                if (student != null)
                {
                    _context.Students.Remove(student);
                    _context.SaveChanges();
                    TempData["successMessage"] = "Student deleted Successfully!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["erroMessage"] = $"Student details is not available with Id: {model.Id} ";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {

				TempData["errorMessage"] = ex.Message;
                return View();
			}
          
        }
	}
}
