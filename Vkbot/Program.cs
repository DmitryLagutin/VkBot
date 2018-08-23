using Accord.Math;
using Accord.Statistics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams;

namespace vkbot
{
    class Program
    {
        static void Main(string[] args)
        {
            var api = new VkApi();

            ulong ApplicationId = 5883941;
            string Login = "+79654273842";
            string Password = "12qwasZX";
            string path = @"C:\Users\Администратор.WIN-QVBBKNJHDMA\Desktop\Vkbot\";

            api.Authorize(new ApiAuthParams
            {
                ApplicationId = ApplicationId,
                Login = Login,
                Password = Password,
                Settings = Settings.All
            });


            Console.WriteLine(api.Token.ToString());

            Thread myThread = new Thread(Potok); //Создаем новый объект потока (Thread)
            myThread.Start(); //запускаем поток

            while (true)
            {

               //--------------Летающий слон---Наука, Путишествия, исследования
               func(ApplicationId, Login, Password, path, "letaushy_slon", -140676466,
               new PostID[][]
               {
                   Helper.PublicList(api, -41053835, 100),
                   Helper.PublicList(api, -24098496, 100),
                   Helper.PublicList(api, -44241745, 100)
               });
               //--------------Мой друг битлджус---Жесткие приколы на грани фола
                func(ApplicationId, Login, Password, path, "My_drug_Bitldjus", -140803827,
                new PostID[][]
                {
                    Helper.PublicList(api, -26419239, 100),
                    Helper.PublicList(api, -30022666, 100),
                    Helper.PublicList(api, -12382740, 100),
                    Helper.PublicList(api, -31836774, 100)
  
                });
                //--------------Я самая---Женские мысли
                func(ApplicationId, Login, Password, path, "I_samay", -140803408,
                new PostID[][]
                {
                    Helper.PublicList(api, -40498005, 100),
                    Helper.PublicList(api, -26669118, 100),
                    Helper.PublicList(api, -32477579, 100),
                    Helper.PublicList(api, -36008740, 100)
  
                });
                //--------------This world is Mine---Жизнь хипстеров
                func(ApplicationId, Login, Password, path, "This_world_is_Mine", -140801423,
                new PostID[][]
                {
                    Helper.PublicList(api, -34298047, 100),
                    Helper.PublicList(api, -36164349, 100),
                    Helper.PublicList(api, -35061290, 100),
                    Helper.PublicList(api, -25397178, 100)
  
                });
                //--------------тЫква---Только юмор
                func(ApplicationId, Login, Password, path, "Tikva", -140799660,
                new PostID[][]
                {
                    Helper.PublicList(api, -57846937, 100),
                    Helper.PublicList(api, -30179569, 100),
                    Helper.PublicList(api, -45441631, 100),
                    Helper.PublicList(api, -34491673, 100)
  
                });
                //--------------Искусный Мужик---про мужиков
                func(ApplicationId, Login, Password, path, "Iskusni_mushik", -140799043,
                new PostID[][]
                {
                    Helper.PublicList(api, -47679753, 100),
                    Helper.PublicList(api, -24713873, 100),
                    Helper.PublicList(api, -39410028, 100),
                    Helper.PublicList(api, -346191, 100)
  
                });
                //--------------Молодой и Смелый---молодеж
                func(ApplicationId, Login, Password, path, "Young_and_Bold", -140798515,
                new PostID[][]
                {
                    Helper.PublicList(api, -26030283, 100),
                    Helper.PublicList(api, -23378353, 100),
                    Helper.PublicList(api, -19799369, 100),
                    Helper.PublicList(api, -35294456, 100)
  
                });
                //--------------free hand---молодеж
                func(ApplicationId, Login, Password, path, "free_hand", -140798160,
                new PostID[][]
                {
                    Helper.PublicList(api, -45608667, 100),
                    Helper.PublicList(api, -57876954, 100),
                    Helper.PublicList(api, -55156099, 100),
                    Helper.PublicList(api, -30277672, 100)
  
                });
                //--------------Экосистема успеха---про успех
                func(ApplicationId, Login, Password, path, "ekosistema_uspexa", -140700308,
                new PostID[][]
                {
                    Helper.PublicList(api, -2089898, 100),
                    Helper.PublicList(api, -34815360, 100),
                    Helper.PublicList(api, -49042487, 100),
                    Helper.PublicList(api, -44195750, 100)
  
                });
                //--------------Дикий пОмидОр---Дикий угар
                func(ApplicationId, Login, Password, path, "dikiy_pomidor", -140697225,
                new PostID[][]
                {
                    Helper.PublicList(api, -26419239, 100),
                    Helper.PublicList(api, -12382740, 100),
                    Helper.PublicList(api, -30179569, 100),
                    Helper.PublicList(api, -460389, 100)
  
                });
                //--------------СочныйТЫЛ---эротика
                func(ApplicationId, Login, Password, path, "sochni_tul", -140696798,
                new PostID[][]
                {
                    Helper.PublicList(api, -72517812, 100),
                    Helper.PublicList(api, -38806371, 100),
                    Helper.PublicList(api, -60804744, 100),
  
                });
                //--------------Зов природы---эротика
                //func(ApplicationId, Login, Password, path, "zov_prirodi", -140696788,
                //new PostID[][]
                //{
                //    Helper.PublicList(api, -27794994, 100),
                //    Helper.PublicList(api, -31071893, 100),
                //    Helper.PublicList(api, -21090314, 100),
                //
                //});
                //--------------Запах мужикА---Мужской журнал
                func(ApplicationId, Login, Password, path, "zapax_muzika", -140699702,
                new PostID[][]
                {
                    Helper.PublicList(api, -39144813, 100),
                    Helper.PublicList(api, -106753446, 100),
                    Helper.PublicList(api, -84838988, 100),
                    Helper.PublicList(api, -25397178, 100)
  
                });
                //--------------кожаный конь---смех
                func(ApplicationId, Login, Password, path, "kojan_kon", -140698998,
                new PostID[][]
                {
                    Helper.PublicList(api, -34298047, 100),
                    Helper.PublicList(api, -109933399, 100),
                    Helper.PublicList(api, -23433159, 100)
  
                });
                //--------------Жуй для тела---фитнес питание
                func(ApplicationId, Login, Password, path, "juy_dly_tela", -140693835,
                new PostID[][]
                {
                    Helper.PublicList(api, -28627911, 100),
                    Helper.PublicList(api, -35113021, 100)
                });
                //--------------лайфhacker---лайфхаки
                func(ApplicationId, Login, Password, path, "lifexaker", -140690042,
                new PostID[][]
                {
                    Helper.PublicList(api, -47679753, 100),
                    Helper.PublicList(api, -24094338, 100),
                    Helper.PublicList(api, -40567146, 100)
  
                });
                //--------------ВАНИ́ЛЬ---женские мысли
                func(ApplicationId, Login, Password, path, "vanil", -140695126,
                new PostID[][]
                {
                    Helper.PublicList(api, -28627911, 100),
                    Helper.PublicList(api, -32477579, 100),
                    Helper.PublicList(api, -40498005, 100),
                    Helper.PublicList(api, -34308709, 100)
  
                });
                //--------------Миллионер из трущеб---мужской журнал
                func(ApplicationId, Login, Password, path, "millioner_iz_trusheb", -140699644,
                new PostID[][]
                {
                    Helper.PublicList(api, -40587282, 100),
                    Helper.PublicList(api, -49438563, 100),
                    Helper.PublicList(api, -49031817, 100),
                    Helper.PublicList(api, -30559917, 100)
  
                });
                //--------------Мысли Вслух---мужской журнал
                func(ApplicationId, Login, Password, path, "misli_vslux", -140683182,
                new PostID[][]
                {
                    Helper.PublicList(api, -29559271, 100),
                    Helper.PublicList(api, -38000455, 100),
                    Helper.PublicList(api, -89960449, 100),
                    Helper.PublicList(api, -44241745, 100)
  
                });





                Console.WriteLine("#####");
                Thread.Sleep(3600 * 1000);

            }
        }

        #region Вспомогательные методы

        //Метод в котором все выполнятеся
        static void func(ulong ApplicationIdPub, string LoginPub, string PasswordPub, string pathFile,  string publicNameSeriaFile, int IdPublic, PostID[][] ArrayPublic)
        {
            try
            {
                #region Основное тело

                var api = new VkApi();

                #region РАСЧЕТ ВРЕМЕНИ

                int Go = 0;     //для открытия
                int timeNow = DateTime.Now.Hour * 100 + DateTime.Now.Minute;

                if (timeNow >= 5 & timeNow <= 655)
                    Go = 1;
                else
                    Go = 1;

                #endregion

                //Авторизация
                api.Authorize(new ApiAuthParams
                {
                    ApplicationId = ApplicationIdPub,
                    Login = LoginPub,
                    Password = PasswordPub,
                    Settings = Settings.All
                });

                string path = pathFile;



                //создаем список выдачи 
                IList<PostID> ListOut = ArrayPublic.Flatten(0).ToList();

                //Непосредственная отработка
                if (Go == 1)
                {
                    for (int i = 0; i < ListOut.Count; i++)
                    {
                        long label = ListOut[i].FuncWallPost(api, path, publicNameSeriaFile, IdPublic);
                        if (label > 0)
                        {
                            Console.WriteLine("Размещен пост " + label.ToString() + " в пабдике " + IdPublic.ToString() + " время " + timeNow.ToString());
                            break;
                        }
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка");
            }


        }

        //Поток
        static void Potok()
        {
            int timeNow = DateTime.Now.Hour * 100 + DateTime.Now.Minute;
        }

        #endregion
    }

    //Вспомогательный класс
    public static class Helper
    {

        #region Сериализация

        //бинарная сериализация (запись в файл) 
        public static void SeriaBinar(string path, object data)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, data);
            }

        }

        //бинарная десериализация (извлечние из файла)
        public static object DeseriaBinar(string path)
        {

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    object newPerson = formatter.Deserialize(fs);
                    return newPerson;
                }

            }
            catch (System.Runtime.Serialization.SerializationException ex)
            {
                return null;
            }
        }

        #endregion

        //Метод который добавляет в список раздачи новые посты
        public static PostID[] PublicList(this VkApi api, long fromGroupID, ulong count)
        {
            PostID[] Array = new PostID[] { };
            try
            {
                var FirstWall = api.Wall.Get(new WallGetParams
                {
                    OwnerId = fromGroupID,
                    Count = count,


                });

                var GoodWall = FirstWall.WallPosts.Where(p => p.Likes.Count >= FirstWall.WallPosts.Select(d => d.Likes.Count).ToArray().Mean()).ToArray();
                IList<PostID> PostID = new List<PostID>();
                for (int i = 0; i < GoodWall.Length; i++)
                {
                    PostID.Add(new PostID() { PostBody = GoodWall[i], PostStringID = GoodWall[i].OwnerId.ToString() + GoodWall[i].Id.ToString() });
                }


                return PostID.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка");
                return Array;
            }
           


           

        }

        public static long FuncWallPost(this PostID post, VkApi api, string path, string PublicName, long GroupID)
        {
            long result = -1;

            IList<string> postKeyList = null;


            if (!File.Exists(path + PublicName + ".bin"))
            {
                File.Create(path + PublicName + ".bin").Close();
                postKeyList = new List<string>();
            }
            else
                postKeyList = (IList<string>)DeseriaBinar(path + PublicName + ".bin") != null ? (IList<string>)DeseriaBinar(path + PublicName + ".bin") : new List<string>();

            //если список больше 30, удаляем первый элемент
            //if (postKeyList.Count() > 30)
            //    postKeyList.Remove(postKeyList.First()); // Либо последний !!!!!!!!!!



            #region Непосредственный сбор контента в список перед отправкой

            IEnumerable<Attachment> groupList = post.PostBody.Attachments;
            IEnumerable<Attachment> grListHistiry = post.PostBody.CopyHistory.Count() != 0 ? post.PostBody.CopyHistory.ElementAt(0).Attachments : null;

            List<MediaAttachment> newList = new List<MediaAttachment>();

            //копируем основной пост
            foreach (var item in groupList)
            {
                newList.Add((MediaAttachment)item.Instance);
            }

            //копируем, если есть репосты там
            if (grListHistiry != null)
            {
                foreach (var item in grListHistiry)
                    newList.Add((MediaAttachment)item.Instance);
            }

            #endregion

            #region Размещение поста

            if (postKeyList.Where(p => p == post.PostStringID).Count() == 0)
            {
                try
                {
                    var newMyPost = api.Wall.Post(new WallPostParams
                    {

                        OwnerId = GroupID,
                        Message = post.PostBody.Text,
                        Attachments = newList,
                        FromGroup = true
                    });

                    postKeyList.Add(post.PostStringID);
                    SeriaBinar(path + PublicName + ".bin", postKeyList);

                    result = newMyPost;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    result = -1;
                }
            }
            else
            {
                Console.WriteLine("Этот пост уже существует");
                result = -1;
            }



            #endregion

            return result;
        }

    }

    public class PostID
    {
        public Post PostBody { get; set; }         //Тело Post  непосредственно то что в апи ВК
        public string PostStringID { get; set; }   //Специально введенное свойство для идентификации
    }
}



