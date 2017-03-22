using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Sinemav1
{
    class Gosterim
    {
        public static string logan = "Yakın gelecekte, yorgun savaşçı Logan'ın önemsediği tek şey hasta olan Profesör X'i Meksika sınırında saklamaktı.Ancak Logan'ın dünyadan ve kendi efsanesinden saklanma çabası, karanlık güçler tarafından takip edilen genç bir Mutant'ın gelişiyle sona erer.";
        public static string yasamKuru = "Genç hırslı bir idareci İsviçre Alplerindeki huzurlu ancak gizemli iyileştirme merkezinden, çalıştığı şirketinin CEO’sunu geri getirmesi için görevlendirilir. Spa merkezindeki mucizevi tedavinin göründüğü gibi olmadığından şüphelenir. Dehşet verici gizemlerini açığa çıkardıkça akıl sağlının sınırları zorlanır. Daha sonra kendisi de tüm ziyaretçilerin muzdarip ve orada kalmalarına sebep olan hastalığa sahip olduğunu öğrenir. HALKA filminin yaratıcı yönetmeni Gore Verbinski, yeni psikolojik gerilimi ile beyazperdelere geliyor.";
        public static string buDunyaninDisinda = "Genç hırslı bir idareci İsviçre Alplerindeki huzurlu ancak gizemli iyileştirme merkezinden, çalıştığı şirketinin CEO’sunu geri getirmesi için görevlendirilir. Spa merkezindeki mucizevi tedavinin göründüğü gibi olmadığından şüphelenir. Dehşet verici gizemlerini açığa çıkardıkça akıl sağlının sınırları zorlanır. Daha sonra kendisi de tüm ziyaretçilerin muzdarip ve orada kalmalarına sebep olan hastalığa sahip olduğunu öğrenir. HALKA filminin yaratıcı yönetmeni Gore Verbinski, yeni psikolojik gerilimi ile beyazperdelere geliyor.";
        public static string deliAsk = "Senaryosunu Emrah ve Murat Kaman'ın yazdığı, yönetmenliğini Murat Kaman ve Murat Dündar'ın yaptığı Deli Aşk, Maraş dondurmacısı Ekrem'in sevdiği kız Neşe'nin kalbini kazanmaya çalışırken gerçek aşkı bulma sürecini anlatıyor.";
        public static string guzelCirkin = "Disney’in canlı çekim (live-action) klasik animasyon uyarlaması “Güzel ve Çirkin”, günümüz izleyicileri için klasik karakterlere yeniden hayat veriyor ve orjinal müziğe sadık kalırken klasiğe pek çok yeni şarkı da ekliyor. “Güzel ve Çirkin” bir canavar tarafında kaleye hapsedilen genç, güzel ve özgür Belle’in hikayesini konu alıyor. Korkularına rağmen Belle, kalenin çalışanlarıyla arkadaş olur, canavarın korkunç dış görünüşünün arkasındaki hassas kalbi ve gerçek Prensi keşfeder.";
        public static string tatlimTatlim = "Dört ayrı çift aynı partide tanışır ve aralarında tatlım-tatlım bir ilişki başlar ise.. Ve bu haybeden gerçeküstü bir aşk ise... İlişkinin her evresi bir durum komedisi iken, bir an hoşlaşılıp ardından hemen didişilir ise... Akla şöyle bir soru gelebilir mi: Ey sevgili sevgililer sizin aşka işiniz yok mu? Yılmaz Erdoğan’ın senaristliğini ve yönetmenliğini üstlendiği, aşkın farklı dönemlerini anlatan bu romantik komedide başrolleri Aylin Kontente, Büşra Pekin, Gupse Özay, Şebnem Bozoklu, Bülent Emrah Parlak, Çağlar Çorumlu, Fatih Artman ve Serkan Keskin paylaşıyor.";
        public static string kingKong = "Filmde farklı alanlardan bir grup araştırmacı, Pasifik’te güzel olduğu kadar da tehlikeli meçhul bir adayı keşfe çıkarlar. Hiçbirisi, Kong efsanesinin yaşadığı yere yol aldıklarından habersizdir.";
        public static string istanbulKirmizisi = "Uzun yıllar yurtdışında yaşayan yazar- editör Orhan Şahin ünlü yönetmen Deniz Soysal’ın ilk kitabı üzerinde çalışmak için İstanbul’a gelir. Deniz zenginliğinin son demlerindeki ailesiyle birlikte bir yalıda yaşamaktadır. Orhan daha ilk günden Deniz’in karmaşık ilişkileri, esrarengiz arkadaşları ve aile bireylerinin ortasında bulur kendini. Yıllar sonra döndüğü İstanbul’u yepyeni gözlerle keşfederken, unuttuğu duyguları yeniden yaşamaya başlayacaktır…";
        public void OzetYazdir(string gelen)
        {
            switch (gelen)
            {
                case "Logan":
                    MessageBox.Show(logan, "Logan Filminin Özeti", MessageBoxButtons.OK);
                    break;
                case "YasamKuru":
                    MessageBox.Show(yasamKuru, "Yaşam Kürü Filminin Özeti", MessageBoxButtons.OK);
                    break;
                case "BuDunyaninDisinda":
                    MessageBox.Show(buDunyaninDisinda, "Bu Dünyanın Dışında Filminin Özeti", MessageBoxButtons.OK);
                    break;
                case "DeliAsk":
                    MessageBox.Show(deliAsk, "Deli Aşk Filminin Özeti", MessageBoxButtons.OK);
                    break;
                case "GuzelCirkin":
                    MessageBox.Show(guzelCirkin, "Güzel ve Çirkin Filminin Özeti", MessageBoxButtons.OK);
                    break;
                case "TatlimTatlim":
                    MessageBox.Show(tatlimTatlim, "Tatlım Tatlım Filminin Özeti", MessageBoxButtons.OK);
                    break;
                case "KingKong":
                    MessageBox.Show(kingKong, "Kong Filminin Özeti", MessageBoxButtons.OK);
                    break;
                case "İstanbulKirmizisi":
                    MessageBox.Show(istanbulKirmizisi, "İstanbul Kırmızısı Filminin Özeti", MessageBoxButtons.OK);
                    break;
                    /*/*/
            }
        }
    }
}
