using App.Domain;
using App.Domain.Interfaces;
using App.Entities.Base;
using App.Services.WCFLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.WCFLib
{
    public partial class MantenimentosService : IMantenimientosService
    {
        public IEnumerable<Artist> GetArtistAll(string nombre)
        {
            IArtistDomain domain = new ArtistDomain();
            
            return domain.GetArtist(nombre);
        }

        public Artist GetArtist(int id)
        {
            IArtistDomain domain = new ArtistDomain();

            return domain.GetArtist(id);
        }

        public bool DeleteArtist(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveArtist(Artist entity)
        {
            throw new NotImplementedException();
        }

    }
}
