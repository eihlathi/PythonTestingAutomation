using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContactManagerWebApi.Models;

namespace ContactManagerWebApi.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsApiController : ControllerBase
    {
        private readonly ContactManagerContext _context;

        public ContactsApiController()
        {
            _context = new();
        }

        [HttpGet]
        [Route("{a:int}/{b:int}/{c:int}")]
        public string RoutingTest(int a, int b, int c = -1)
        {
            return $"a: {a}, b: {b}, c: {c}";
        }

        // GET: api/contacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            return await _context.Contacts.ToListAsync();
        }

        // GET: api/contacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);

            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }

        // PUT: api/contacts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContact(int id, Contact contact)
        {
            if (id != contact.ContactId)
            {
                return BadRequest();
            }

            Contact? dbContact = await _context.Contacts.FindAsync(id);
            if (dbContact == null)
            {
                return NotFound();
            }

            // copy the values from the input contact to the db contact
            dbContact.ContactName = contact.ContactName;
            dbContact.ContactEmail = contact.ContactEmail;
            dbContact.ContactComments = contact.ContactComments;

            // update the modified date
            dbContact.ModifiedAt = DateTime.Now;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/contacts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Contact>> PostContact(Contact contact)
        {
            contact.CreatedAt = DateTime.Now;
            contact.Active = true;

            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContact", new { id = contact.ContactId }, contact);
        }

        // DELETE: api/contacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            contact.DeletedAt = DateTime.Now;
            contact.Active = false; // soft delete

            //_context.Contacts.Remove(contact); // hard delete
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactExists(int id)
        {
            return _context.Contacts.Any(e => e.ContactId == id);
        }
    }
}
