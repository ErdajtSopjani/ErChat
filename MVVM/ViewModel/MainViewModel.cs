using _11.ChatApp.Core;
using _11.ChatApp.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ChatApp.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }


        public RelayCommand SendCommand { get; set; }


        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return  _selectedContact; }
            set 
            {  
                _selectedContact = value; 
                OnPropertyChanged();
            }
        }



        public string _message;
        public string Message
        {
            get { return _message; }
            set 
            { 
                _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            SendCommand = new RelayCommand(o =>
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false
                });

                Message = "";

            });


            Messages.Add(new MessageModel
            {
                Username = "Matzz",
                UsernameColor = "#409aff",
                ImageSource = "https://mieker.design/content/uploads/2021/11/corporate-design-trier-luxembourg-logo-farben-matz.gif",
                Message = "Hello, how are you?",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            Messages.Add(new MessageModel
            {
                Username = "Michael",
                UsernameColor = "#409aff",
                ImageSource = "https://www.mintface.xyz/content/images/2021/08/QmTndiF423kjdXsNzsip1QQkBQqDuzDhJnGuJAXtv4XXiZ-1.png",
                Message = "I'm good. u?",
                Time = DateTime.Now,
                IsNativeOrigin = false,
            });
            
            Messages.Add(new MessageModel
            {
                Username = "Pluto",
                UsernameColor = "#409aff",
                ImageSource = "https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto,q_auto,f_auto/attachments/delivery/asset/7ad5100b21255df5492ab193aa116e6b-1642426015/512x512%20gif%20fire/custom-discord-pfp-animated-gif-logo-intro.gif",
                Message = "Hey matzz, you got the cash?",
                Time = DateTime.Now,
                IsNativeOrigin = false,
            });

            Messages.Add(new MessageModel
            {
                Username = "Matzz",
                UsernameColor = "#409aff",
                ImageSource = "https://mieker.design/content/uploads/2021/11/corporate-design-trier-luxembourg-logo-farben-matz.gif",
                Message = "Yes, let's meet up!",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            Messages.Add(new MessageModel
            {
                Username = "Neptune",
                UsernameColor = "#409aff",
                ImageSource = "https://observatorioblockchain.com/wp-content/uploads/2022/08/Que-son-y-para-que-se-utilizan-las-colecciones-PFP-NFT.jpg",
                Message = "where u at?",
                Time = DateTime.Now,
                IsNativeOrigin = false,
            });

            Messages.Add(new MessageModel
            {
                Username = "Donald",
                UsernameColor = "#409aff",
                ImageSource = "https://www.rollingstone.com/wp-content/uploads/2023/01/donald-trump-leaving-social-media.jpg?w=1581&h=1054&crop=1",
                Message = "come to my place",
                Time = DateTime.Now,
                IsNativeOrigin = true,
            });

            Messages.Add(new MessageModel
            {
                Username = "Erdajt",
                UsernameColor = "#ff0000",
                ImageSource = "https://instagram.fprn4-1.fna.fbcdn.net/v/t51.2885-19/331886491_156789793838056_2407606836117798842_n.jpg?stp=dst-jpg_s150x150&_nc_ht=instagram.fprn4-1.fna.fbcdn.net&_nc_cat=104&_nc_ohc=lPPzdNcXNmYAX8CVQ27&edm=AOQ1c0wBAAAA&ccb=7-5&oh=00_AfBEC3n3yzmcaClf8LsgalbjSJjIWe5bIU2lk0aJ4vJUpQ&oe=6488E187&_nc_sid=f70a57",
                Message = "We meeting up?",
                Time = DateTime.Now,
                IsNativeOrigin = false,
            });

            Messages.Add(new MessageModel
            {
                Username = "Neptune",
                UsernameColor = "#409aff",
                ImageSource = "https://observatorioblockchain.com/wp-content/uploads/2022/08/Que-son-y-para-que-se-utilizan-las-colecciones-PFP-NFT.jpg",
                Message = "Yes, Donald's place.",
                Time = DateTime.Now,
                IsNativeOrigin = false,
            });

            Messages.Add(new MessageModel
            {
                Username = "Erdajt",
                UsernameColor = "#ff0000",
                ImageSource = "https://instagram.fprn4-1.fna.fbcdn.net/v/t51.2885-19/331886491_156789793838056_2407606836117798842_n.jpg?stp=dst-jpg_s150x150&_nc_ht=instagram.fprn4-1.fna.fbcdn.net&_nc_cat=104&_nc_ohc=lPPzdNcXNmYAX8CVQ27&edm=AOQ1c0wBAAAA&ccb=7-5&oh=00_AfBEC3n3yzmcaClf8LsgalbjSJjIWe5bIU2lk0aJ4vJUpQ&oe=6488E187&_nc_sid=f70a57",
                Message = "On my way there!",
                Time = DateTime.Now,
                IsNativeOrigin = false,
            });

            Contacts.Add(new ContactModel
            {
                Username = "Matzz",
                ImageSource = "https://mieker.design/content/uploads/2021/11/corporate-design-trier-luxembourg-logo-farben-matz.gif",
                Messages = Messages
            });
            Contacts.Add(new ContactModel
            {
                Username = "Michael",
                ImageSource = "https://www.mintface.xyz/content/images/2021/08/QmTndiF423kjdXsNzsip1QQkBQqDuzDhJnGuJAXtv4XXiZ-1.png",
                Messages = Messages
            });
            Contacts.Add(new ContactModel
            {
                Username = "Pluto",
                ImageSource = "https://fiverr-res.cloudinary.com/images/t_main1,q_auto,f_auto,q_auto,f_auto/attachments/delivery/asset/7ad5100b21255df5492ab193aa116e6b-1642426015/512x512%20gif%20fire/custom-discord-pfp-animated-gif-logo-intro.gif",
                Messages = Messages
            });
            Contacts.Add(new ContactModel
            {
                Username = "Neptune",
                ImageSource = "https://observatorioblockchain.com/wp-content/uploads/2022/08/Que-son-y-para-que-se-utilizan-las-colecciones-PFP-NFT.jpg",
                Messages = Messages
            });
            Contacts.Add(new ContactModel
            {
                Username = "Donald",
                ImageSource = "https://www.rollingstone.com/wp-content/uploads/2023/01/donald-trump-leaving-social-media.jpg?w=1581&h=1054&crop=1",
                Messages = Messages
            });

        }

    }
}
