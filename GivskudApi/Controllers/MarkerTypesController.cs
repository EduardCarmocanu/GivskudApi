using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GivskudApi.Data;
using GivskudApi.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GivskudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
	[EnableCors("GivskudPolicy")]
    public class MarkerTypesController : ControllerBase
    {
		private readonly ApplicationDataContext _context;

		public MarkerTypesController(ApplicationDataContext context)
		{
			_context = context;
		}

		// GET: api/MarkerTypes/
		[HttpGet]
		public IEnumerable<MarkerType> GetMarkerTypes()
		{
			return _context.MarkerTypes;
		}

     }
}