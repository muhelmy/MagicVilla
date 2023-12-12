using MagicVilla_API.Data;
using MagicVilla_API.DTOs;
using MagicVilla_API.Logging;
using MagicVilla_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace MagicVilla_API.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDBContext _db;
        public VillaAPIController(ApplicationDBContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            
            return Ok (_db.Villas.ToList ());
        }
        [HttpGet]
        [Route ("id:int", Name = "GetVilla")]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status404NotFound)]

        public ActionResult<VillaDTO> GetVilla(int id)
        {
            if (id == 0)
            {
               
                return BadRequest ();
            }
            var villa = _db.Villas.FirstOrDefault (v => v.Id == id);
            if (villa == null)
            {
                return NotFound ();
            }
            return Ok (villa);
        }
        [HttpPost]
        [ProducesResponseType (StatusCodes.Status200OK)]
        [ProducesResponseType (StatusCodes.Status201Created)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDTO> CreateVilla(VillaDTO villa)
        {
            if (_db.Villas.FirstOrDefault (o => o.Name.ToLower () == villa.Name.ToLower ()) != null)
            {
                ModelState.AddModelError ("Custom Error", "Villa Already Exist");
                return BadRequest (ModelState);
            }
            if (villa == null)
            {
                return BadRequest (villa);
            }
            if (villa.Id > 0)
            {
                return StatusCode (StatusCodes.Status500InternalServerError);
            }


            Villa model = new ()
            {
                Amenity = villa.Amenity,
                Details = villa.Details,
                Name = villa.Name,
                Occupancy = villa.Occupancy,
                Sqft = villa.Sqft,
                ImageUrl = villa.ImageUrl,
                Rate = villa.Rate,
                Id = villa.Id,

            };
            _db.Villas.Add(model);
            _db.SaveChanges();
            return CreatedAtRoute ("GetVilla", new { id = villa.Id }, villa);
        }
        [HttpDelete]
        [ProducesResponseType (StatusCodes.Status204NoContent)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        [ProducesResponseType (StatusCodes.Status404NotFound)]
        public IActionResult DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest ();
            }
            var villa = _db.Villas.FirstOrDefault (v => v.Id == id);
            if (villa == null)
            {
                return NotFound ();
            }
            _db.Villas.Remove (villa);
            _db.SaveChanges ();
            return NoContent ();
        }
        [HttpPut]
        [ProducesResponseType (StatusCodes.Status204NoContent)]
        [ProducesResponseType (StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDTO> UpdateVilla(int id, VillaDTO villa)
        {
            if (villa == null || id != villa.Id)
            {
                return BadRequest ();
            }
            Villa model = new ()
            {
                Amenity = villa.Amenity,
                Details = villa.Details,
                Name = villa.Name,
                Occupancy = villa.Occupancy,
                Sqft = villa.Sqft,
                ImageUrl = villa.ImageUrl,
                Rate = villa.Rate,
                Id = villa.Id,

            };
            _db.Villas.Update (model);
            _db.SaveChanges();


            return NoContent ();
        }
    }
}




