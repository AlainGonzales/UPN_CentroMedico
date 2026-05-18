using CentroMedico.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico.Data
{
    internal class MockData
    {
        public static List<Medico> ObtenerMedicos()
        {
            return new List<Medico>
            {
                new Medico{
                    DNI = "11111111",
                    Nombre = "Dr. Gregory House",
                    Especialidad = Especialidad.MedicinaGeneral
                },
                new Medico{
                    DNI = "22222222",
                    Nombre = "Dra. Lastimosa Curita",
                    Especialidad = Especialidad.Oncologia
                },
                new Medico{
                    DNI = "33333333",
                    Nombre = "Dr. Juanete Grande",
                    Especialidad = Especialidad.Endocrinologia
                },
                new Medico{
                    DNI = "44444444",
                    Nombre = "Dr. Anibal Esquivel",
                    Especialidad = Especialidad.Cardiologia
                },
                new Medico{
                    DNI = "55555555",
                    Nombre = "Dr. Miguel Angel",
                    Especialidad = Especialidad.Nutricion
                },
                new Medico{
                    DNI = "66666666",
                    Nombre = "Dr. Miguel Anibal",
                    Especialidad = Especialidad.Dermatologia
                },
                new Medico{
                    DNI = "77777777",
                    Nombre = "Dr. Yair Varas",
                    Especialidad = Especialidad.Neurologia
                },
                new Medico{
                    DNI = "88888888",
                    Nombre = "Dra. Jhoselyn Melendez",
                    Especialidad = Especialidad.Pediatria
                },
                new Medico{
                    DNI = "99999999",
                    Nombre = "Dr. Esteban Dido",
                    Especialidad = Especialidad.Traumatologia
                }
            };
        }
    }
}
