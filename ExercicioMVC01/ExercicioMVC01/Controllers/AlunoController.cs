using ExercicioMVC01.Models;
using ExercicioMVC01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExercicioMVC01.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        [HttpGet]
        public ActionResult Index()
        {
            List<Aluno> alunos = new AlunoRepository().ObterTodos();
            ViewBag.Alunos = alunos;
            ViewBag.TituloPagina = "Alunos";
            return View();
        }

        [HttpGet]
        public ActionResult Cadastro()
        {
            ViewBag.TituloPagina = "Alunos - Cadastro";
            ViewBag.Aluno = new Aluno();
            return View();
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            Aluno aluno = new AlunoRepository().ObterPeloId(id);
            ViewBag.Aluno = aluno;
            return View();
        }

        [HttpGet]
        public ActionResult Excluir(int id)
        {
            bool erased = new AlunoRepository().Excluir(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Store(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                int identifier = new AlunoRepository().Cadastrar(aluno);
                return RedirectToAction("Index", new { id = identifier });
            }
            ViewBag.Aluno = aluno;
            return View("Cadastro");
        }

        [HttpPost]
        public ActionResult Update(Aluno aluno)
        {
            bool altered = new AlunoRepository().Alterar(aluno);
            return RedirectToAction("Index");
        }


    
       




    }
}