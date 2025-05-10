using hemtest.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hemtest.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class FrequentWords : ControllerBase
    {
        private readonly Counter _counter = new Counter();

        // POST api/<FrequentWords>
        [HttpPost]
        public async Task<ActionResult<Dictionary<string, int>>> Post([FromBody] string input)
        {

            if (string.IsNullOrWhiteSpace(input))
            {
                return BadRequest("Input cant be empty");
            }

            try
            {
                await _counter.SaveWords(input);
                await _counter.SplitWords();
                var results = await _counter.CalculateFrequentWords();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest($"an Error has occured: {ex.Message}");
            }
        }
    }
}
