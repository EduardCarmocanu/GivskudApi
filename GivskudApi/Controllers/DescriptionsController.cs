using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GivskudApi.Data;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace GivskudApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[EnableCors("GivskudPolicy")]
	public class DescriptionsController : ControllerBase
	{
		private readonly ApplicationDataContext _context;

		public DescriptionsController(ApplicationDataContext context)
		{
			_context = context;
		}

		// GET: api/descriptions/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetDescription([FromRoute] int id)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var description = await _context.Descriptions.FindAsync(id);

			if (description == null)
			{
				return NotFound();
			}

			return Ok(description);
		}
	}
}
