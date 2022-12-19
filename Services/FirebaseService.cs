using Firebase.Database;
using Firebase.Database.Query;
using Web.Models;

namespace Web.Services
{
    public class FirebaseService
    {
        private FirebaseClient firebase;
        public FirebaseService()
        {
            firebase = new FirebaseClient("https://drivergate-5b95f-default-rtdb.firebaseio.com/");
        }
        public async Task<bool> SaveMessage(Contact message)
        {
            var _message = await firebase.Child("Web Messages")
                .PostAsync(message);
            if (_message != null)
                return true;
            return false;
        }
    }
}
