using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        // GET: api/<ProdutoController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Models.Produto> produtos = new List<Models.Produto>();

            for (int i = 0; i < 4; i++)
            {
                Models.Produto produto = new Models.Produto();
                produto.Id = i;
                produto.Nome = "Tenis";
                produto.Preco = 400;
                
                produtos.Add(produto);
            }

            return Ok(produtos);
        }

        // GET api/<ProdutoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProdutoController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Produto produto)
        {
            return Ok(produto);
        }

        // PUT api/<ProdutoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProdutoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
