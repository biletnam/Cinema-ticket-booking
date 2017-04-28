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
        public string[] loganSeans = { "09:45", "12:20", "15:15", "18:10", "21:10" };
        public string[] yasamkuruSeans = { "11:00", "14:30", "16:30", "18:00", "21:30" };
        public string[] budunyanindisindaSeans = { "11:10", "13:50", "16:25", "19:00", "21:35" };
        public string[] deliaskSeans = { "10:15", "12:15", "14:40", "17:00", "19:20", "21:40" };
        public string[] guzelcirkinSeans = { "11:00", "13:45", "16:30", "19:15", "22:00" };
        public string[] tatlimtatlimSeans = { "10:30", "12:45", "15:00", "17:20", "19:40", "22:00" };
        public string[] kingkongSeans = { "11:00", "13:40", "16:20", "19:00", "21:50" };
        public string[] istanbulkirmizisiSeans = { "10:50", "13:25", "16:10", "18:50", "21:30"};
        public int loganSalonNo = 1;
        public int yasamkuruSalonNo = 2;
        public int budunyanindisindaSalonNo = 3;
        public int deliaskSalonNo = 4;
        public int guzelcirkinSalonNo = 5;
        public int tatlimtatlimSalonNo = 6;
        public int kongSalonNo = 7;
        public int istanbulkirmizisiSalonNo = 8;
        public string[] salonFilmIsim = {" ", "Logan", "Yaşam Kürü" , "Bu Dünyanın Dışında", "Deli Aşk", "Güzen ve Çirkin", "Tatlım Tatlım", "Kong", "İstanbul Kırmızısı" };
        public string logan = "Yakın gelecekte, yorgun savaşçı Logan'ın önemsediği tek şey hasta olan Profesör X'i Meksika sınırında saklamaktı.Ancak Logan'ın dünyadan ve kendi efsanesinden saklanma çabası, karanlık güçler tarafından takip edilen genç bir Mutant'ın gelişiyle sona erer.";
        public string yasamKuru = "Genç hırslı bir idareci İsviçre Alplerindeki huzurlu ancak gizemli iyileştirme merkezinden, çalıştığı şirketinin CEO’sunu geri getirmesi için görevlendirilir. Spa merkezindeki mucizevi tedavinin göründüğü gibi olmadığından şüphelenir. Dehşet verici gizemlerini açığa çıkardıkça akıl sağlının sınırları zorlanır. Daha sonra kendisi de tüm ziyaretçilerin muzdarip ve orada kalmalarına sebep olan hastalığa sahip olduğunu öğrenir. HALKA filminin yaratıcı yönetmeni Gore Verbinski, yeni psikolojik gerilimi ile beyazperdelere geliyor.";
        public string buDunyaninDisinda = "Gezegenler arası macerada Mars'a gelen astronotlardan biri kırmızı gezegende dünyaya gelen ilk insanı doğururken ölür. Böylece Gardner Elliot (Asa Butterfield) Mars'ta doğan ilk bebek olur. Bilim insanları tarafından büyütülen Gardner sadece 14 insan tanır. Gardner 16 yaşına geldiğinde merak uyandırıcı ve son derece akıllı bir çocuk olur. Gardner, babası ve dünyayla ilgili ipuçlarını araştırırken, koruyucu bir kişiliğe sahip Tulsa ile gizli ve gezegenler arası bir dostluğa başlar. Sonunda Dünya'ya gidebilmek için bir şans yakalayan Gardner Dünya'daki her şeyi keşfetmek ister. Ancak keşifler başladıktan sonra, bilim adamları Gardner'in organlarının Dünya'nın yerçekimine dayanamayacağını fark ederler. Gardner, Tulsa'yla birlikte zamana karşı bir yarışa katılır.";
        public string deliAsk = "Senaryosunu Emrah ve Murat Kaman'ın yazdığı, yönetmenliğini Murat Kaman ve Murat Dündar'ın yaptığı Deli Aşk, Maraş dondurmacısı Ekrem'in sevdiği kız Neşe'nin kalbini kazanmaya çalışırken gerçek aşkı bulma sürecini anlatıyor.";
        public string guzelCirkin = "Disney’in canlı çekim (live-action) klasik animasyon uyarlaması “Güzel ve Çirkin”, günümüz izleyicileri için klasik karakterlere yeniden hayat veriyor ve orjinal müziğe sadık kalırken klasiğe pek çok yeni şarkı da ekliyor. “Güzel ve Çirkin” bir canavar tarafında kaleye hapsedilen genç, güzel ve özgür Belle’in hikayesini konu alıyor. Korkularına rağmen Belle, kalenin çalışanlarıyla arkadaş olur, canavarın korkunç dış görünüşünün arkasındaki hassas kalbi ve gerçek Prensi keşfeder.";
        public string tatlimTatlim = "Dört ayrı çift aynı partide tanışır ve aralarında tatlım-tatlım bir ilişki başlar ise.. Ve bu haybeden gerçeküstü bir aşk ise... İlişkinin her evresi bir durum komedisi iken, bir an hoşlaşılıp ardından hemen didişilir ise... Akla şöyle bir soru gelebilir mi: Ey sevgili sevgililer sizin aşka işiniz yok mu? Yılmaz Erdoğan’ın senaristliğini ve yönetmenliğini üstlendiği, aşkın farklı dönemlerini anlatan bu romantik komedide başrolleri Aylin Kontente, Büşra Pekin, Gupse Özay, Şebnem Bozoklu, Bülent Emrah Parlak, Çağlar Çorumlu, Fatih Artman ve Serkan Keskin paylaşıyor.";
        public string kingKong = "Filmde farklı alanlardan bir grup araştırmacı, Pasifik’te güzel olduğu kadar da tehlikeli meçhul bir adayı keşfe çıkarlar. Hiçbirisi, Kong efsanesinin yaşadığı yere yol aldıklarından habersizdir.";
        public string istanbulKirmizisi = "Uzun yıllar yurtdışında yaşayan yazar- editör Orhan Şahin ünlü yönetmen Deniz Soysal’ın ilk kitabı üzerinde çalışmak için İstanbul’a gelir. Deniz zenginliğinin son demlerindeki ailesiyle birlikte bir yalıda yaşamaktadır. Orhan daha ilk günden Deniz’in karmaşık ilişkileri, esrarengiz arkadaşları ve aile bireylerinin ortasında bulur kendini. Yıllar sonra döndüğü İstanbul’u yepyeni gözlerle keşfederken, unuttuğu duyguları yeniden yaşamaya başlayacaktır…";
     
    }
}
