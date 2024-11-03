using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api_shopping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        // GET: api/<ClienteController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Models.Cliente> clientes = new List<Models.Cliente>();

            for (int i = 0; i < 4; i++)
            {
                Models.Cliente cliente = new Models.Cliente();
                cliente.Id = i;
                cliente.Nome = "Victor";
                cliente.DataNasc = 28081997;
                
                clientes.Add(cliente);
            }

            return Ok(clientes);
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ClienteController>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Cliente cliente)
        {
            return Ok(cliente); 
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
