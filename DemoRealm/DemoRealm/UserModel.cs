using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace DemoRealm
{
    public class UserModel : RealmObject
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Nota { get; set; }

        public static void SalvarUsuario(UserModel user)
        {
            var realm = Realm.GetInstance();

            realm.Write(() =>
            {
                realm.Add(user);
            });
            

        }
    }
}
