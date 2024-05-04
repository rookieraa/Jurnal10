using Microsoft.AspNetCore.Mvc;

namespace Jurnal10.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaControllers
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>()
        {
            new Mahasiswa("Najwa Aulia Zahra", "1302220024", ["KPL", "PBO"], 46),
            new Mahasiswa("Hasan Nurrahman Pane", "1302220033", ["Dasar Jaringan Komputer", "BASDAT"], 46),
            new Mahasiswa("Ghifari Permata Alwy", "1302220031", ["Pengalaman Pengguna", "KWU"], 46)
        };
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpDelete("{id}")]
        public void Delete (int id)
        {
            listMahasiswa.RemoveAt(id);
        }
        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }
    }

}
