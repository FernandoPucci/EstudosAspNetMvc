using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TesteAdoNetRest.Dal;
using TesteAdoNetRest.Models;

namespace TesteAdoNetRest.Controllers
{
    public class ProdutoController : ApiController
    {
        // GET api/produto
        //public IEnumerable<string> Get()
        //{
        //            return new string[] { "value1", "value2" };
        //}

        public List<Produto> Get()
        {
            ProdutoDal dal = new ProdutoDal();

            List<Produto>  produtos = dal.GetProdutos();
            return produtos;

        }


        // GET api/produto/5
        public Produto Get(int id)
        {
            ProdutoDal dal = new ProdutoDal();

            Produto produto = dal.GetProdutoById(id);
            return produto;
        }

        // POST api/produto
        public void Post([FromBody]string value)
        {
        }

        // PUT api/produto/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/produto/5
        public void Delete(int id)
        {
        }
    }
}
