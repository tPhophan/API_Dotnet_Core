using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPI.Models;

namespace webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatsContoller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Cats> Get()
        {
            List<Cats> cats = new List<Cats>();
            cats.Add(new Cats
            {
                Id = 1,
                titile = "แมวเปอร์เซีย (Persian)",
                text = "แมวที่มีถิ่นกำเนิดอยู่ในแถบเปอร์เซีย หรืออิหร่าน ถูกนำไปเลี้ยงในประเทศต่าง ๆ ทั้งในยุโรปและอเมริกาเป็นเวลาเกือบร้อยปีมาแล้ว เปอร์เซียเป็นแมวต่างประเทศสายพันธุ์แรกที่ถูกนำเข้ามาในประเทศไทย ด้วยหน้าตาที่น่ารักน่าเอ็นดู ขนยาวสวยเงางามหลากหลายสีสันของแมวเปอร์เซียจึงเป็นที่นิยมมาก",
                img = "https://www.thailandexhibition.com/images/Admin-talks/articles/5f0bde906b044/images/%E0%B9%81%E0%B8%A1%E0%B8%A7%E0%B9%80%E0%B8%9B%E0%B8%AD%E0%B8%A3%E0%B9%8C%E0%B9%80%E0%B8%8B%E0%B8%B5%E0%B8%A2-1-1.jpg",
                link = "https://www.purina.co.th/find-a-pet/cat-breeds/persian-long-hair"
            });
            cats.Add(new Cats
            {
                Id = 2,
                titile = "แมวอเมริกัน ชอร์ตแฮร์ (American Shorthair)",
                text = "แมวสายพันธุ์อเมริกาที่สืบเชื้อสายมาจากประเทศในแถบยุโรป และแพร่พันธุ์มายังอเมริกา มีบรรพบุรุษเป็นแมวสายพันธุ์บริติช ช็อตแฮร์ เมื่อสมัยที่ชาวยุโรปเดินทางไปแสวงหาถิ่นที่อยู่ใหม่ โดยพวกเขาได้นำแมวอเมริกันชอร์ตแฮร์ ติดเรือไปด้วย เพื่อป้องกันไม่ให้หนูทำลายข้าวของ และได้มีการพัฒนาสายพันธุ์ในเวลาต่อมา จนกระทั่งกลายเป็นแมวพื้นเมืองขนสั้นของอเมริกาไปในที่สุด",
                img = "https://www.thailandexhibition.com/images/Admin-talks/articles/5f0bde906b044/images/%E0%B9%81%E0%B8%A1%E0%B8%A7%E0%B8%AD%E0%B9%80%E0%B8%A1%E0%B8%A3%E0%B8%B4%E0%B8%81%E0%B8%B2-2.jpg",
                link = "https://www.purina.co.th/find-a-pet/cat-breeds/american-shorthair"
            });
            cats.Add(new Cats
            {
                Id = 3,
                titile = "แมวสก็อตติช โฟลด์ (Scottish Fold)",
                text = "มีถิ่นกำเนิดในประเทศสก๊อตแลนด์ ถูกค้นพบครั้งแรกในปี ค.ศ.1961 ชื่อว่า Susie มีลักษณะเป็นแมวสีขาวที่มีหูพับไปด้านหน้าและด้านหลัง ใบหน้ามีลักษณะคล้ายนกฮูก หรือนาก หลัง Susie ให้กำเนิดลูกแมวน้อยหูพับ 2 ตัว William Ross ชายเลี้ยงแกะ ได้นำไปผสมพันธุ์กับ บริติช ชอร์ตแฮร์ จนกลายเป็นต้นกำเนิดของสายพันธุ์นี้ และได้รับการจดทะเบียนอย่างถูกต้องที่รับรองโดย The Governing Council of the Cat Fancy ของประเทศอังกฤษ",
                img = "https://www.thailandexhibition.com/images/Admin-talks/articles/5f0bde906b044/images/%E0%B9%81%E0%B8%A1%E0%B8%A7%E0%B8%AA%E0%B8%81%E0%B9%87%E0%B8%AD%E0%B8%95%E0%B8%95%E0%B8%B4%E0%B8%8A-3.jpg",
                link = "https://www.purina.co.th/find-a-pet/cat-breeds/scottish-fold"
            });
            cats.Add(new Cats
            {
                Id = 4,
                titile = "แมววิเชียรมาศ (Siamese)",
                text = "มีถิ่นกำเนิดอยู่ในประเทศไทย ที่ชาวต่างชาติรู้จักกันดีในชื่อ Siamese Cat หรือแมวสยาม เป็นแมวไทยโบราณที่มักเลี้ยงกันในวัง ตั้งแต่สมัยอยุธยา และเป็นแมวมงคลตามตำรา เชื่อว่าเป็นแมวแห่งโชคลาภ",
                img = "https://www.thailandexhibition.com/images/Admin-talks/articles/5f0bde906b044/images/%E0%B9%81%E0%B8%A1%E0%B8%A7%E0%B8%A7%E0%B8%B4%E0%B9%80%E0%B8%8A%E0%B8%B5%E0%B8%A2%E0%B8%A3%E0%B8%A1%E0%B8%B2%E0%B8%A8-4.jpg",
                link = "https://www.purina.co.th/find-a-pet/cat-breeds/siamese"
            });
            cats.Add(new Cats
            {
                Id = 5,
                titile = "แมวโคราช (Korat)",
                text = "แมวโคราช มีชื่อเรียกมากมาย แมวสีสวาด แมวมาเลศ แมวดอกเลา แมวสีเทา ต้นกำเนิดพบที่อำเภอพิมาย จังหวัดนครราชสีมา เป็นแมวที่ให้โชคลาภที่ดี 17 ตัวของประเทศไทย ผูกพันกับคนไทยมานาน เป็นแมวที่ใช้ในพิธีแห่นางแมวขอฝน",
                img = "https://www.thailandexhibition.com/images/Admin-talks/articles/5f0bde906b044/images/%E0%B9%81%E0%B8%A1%E0%B8%A7%E0%B9%82%E0%B8%84%E0%B8%A3%E0%B8%B2%E0%B8%8A-5.jpg",
                link = "https://www.purina.co.th/find-a-pet/cat-breeds/korat"
            });
            cats.Add(new Cats
            {
                Id = 6,
                titile = "แมวเอ็กโซติก (Exotic)",
                text = "แมวเอ็กโซติก ถูกพัฒนาสายพันธุ์ขึ้นในประเทศสหรัฐอเมริกายในช่วงทศวรรษที่ 1960 ผสมพันธุ์ระหว่างแมวพันเปอร์เซีย กับอเมริกันขนสั้น (American Shorthair) เกิดเป็นแมวพันธุ์เอ็กโซติก",
                img = "https://www.thailandexhibition.com/images/Admin-talks/articles/5f0bde906b044/images/%E0%B9%81%E0%B8%A1%E0%B8%A7%E0%B9%80%E0%B8%AD%E0%B9%87%E0%B8%81%E0%B9%82%E0%B8%8B%E0%B8%95%E0%B8%B4%E0%B8%81-6.jpg",
                link = "https://www.purina.co.th/find-a-pet/cat-breeds/exotic-shorthair"
            });
            cats.Add(new Cats
            {
                Id = 7,
                titile = "แมวบริติช ชอร์ตแฮร์ (British Shorthair)",
                text = "แมวสายพันธุ์บริติช ชอร์ตแฮร์นั้นสืบเชื้อสายมาจากแมวโรมันที่ถูกนำมายังเกาะอังกฤษโดยชาวโรมัน แมวสายพันธุ์นี้อาจจะผสมข้ามสายพันธุ์กับแมวในท้องถิ่นบนเกาะและยังคงเป็นสัตว์เลี้ยงภายในบ้าน",
                img = "https://www.thailandexhibition.com/images/Admin-talks/articles/5f0bde906b044/images/%E0%B9%81%E0%B8%A1%E0%B8%A7%E0%B8%9A%E0%B8%A3%E0%B8%B4%E0%B8%95%E0%B8%B4%E0%B8%8A-8.jpg",
                link = "https://www.purina.co.th/find-a-pet/cat-breeds/british-shorthair"
            });
            cats.Add(new Cats
            {
                Id = 8,
                titile = "แมวเมนคูน (Main Coon)",
                text = "เมนคูนเกิดจากการผสมข้ามสายพันธุ์โดยธรรมชาติที่ยังคงลักษณะเฉพาะของแมวป่าบางอย่างไว้ จึงเป็นสายพันธุ์แมวที่มีขนาดใหญ่ที่สุด เมื่อโตเต็มที่จะมีน้ำหนักถึง 15 กิโลกรัมขนาดเท่าสุนัข แมวสายพันธุ์เก่าแก่ที่สุดพันธุ์หนึ่งของสหรัฐอเมริกา มีถิ่นกำเนิดในรัฐเมน",
                img = "https://www.thailandexhibition.com/images/Admin-talks/articles/5f0bde906b044/images/%E0%B9%81%E0%B8%A1%E0%B8%A7%E0%B9%80%E0%B8%A1%E0%B8%99%E0%B8%84%E0%B8%B9%E0%B8%99-9.jpg",
                link = "https://www.purina.co.th/find-a-pet/cat-breeds/maine-coon"
            });
            cats.Add(new Cats
            {
                Id = 9,
                titile = "แมวสฟิงซ์ (Sphynx Cat)",
                text = "สฟิงซ์ได้รับความนิยมเพิ่มมากขึ้นเรื่อย ๆ ในไทย ด้วยหน้าตาเป็นเอกลักษณ์ ถูกเรียกว่าเป็นแมวพันธุ์ที่ไม่มีขน แต่ที่จริงแล้วมันมีขนปกคลุมบาง ๆ เหมาะกับคนที่แพ้ขนแมว มีต้นกำเนิดมาจากประทศแคนดา",
                img = "https://www.thailandexhibition.com/images/Admin-talks/articles/5f0bde906b044/images/%E0%B9%81%E0%B8%A1%E0%B8%A7%E0%B8%AA%E0%B8%9F%E0%B8%B4%E0%B8%87%E0%B8%8B%E0%B9%8C-10.jpg",
                link = "https://www.purina.co.th/find-a-pet/cat-breeds/sphynx"
            });
            cats.Add(new Cats
            {
                Id = 10,
                titile = "แมวเบงกอล (Bengal)",
                text = "แมวเบงกอลเป็นแมวที่มีลวดลายสวยงาม คล้ายลูกเสือดาวตัวน้อย ๆ คาดว่าแมวเบงกอลเกิดจาการผสมพันธุ์ระหว่างแมวดาวกับแมวบ้านสายพันธุ์อียิปต์เชียนมัวร์ ซึ่งเป็นแมวอียิปต์โบราณ ที่มีโครงสร้างเป็นลายจุด ลักษณะคล้ายแมวป่า โดยถูกนำมาพัฒนาสายพันธุ์ ด้วยฝีมือของ Jean Mills หญิงสาวชาวอเมริกัน ที่หลงใหลคลั่งไคล้ในลวดลายของแมวป่า พร้อมกับตั้งชื่อของมันตามชื่อวิทยาศาสตร์ของแมวป่าที่เรียกกันว่า Felis Bengolensis",
                img = "https://www.thailandexhibition.com/images/Admin-talks/articles/5f0bde906b044/images/%E0%B9%81%E0%B8%A1%E0%B8%A7%E0%B9%80%E0%B8%9A%E0%B8%87%E0%B8%81%E0%B8%AD%E0%B8%A5-12.jpg",
                link = "https://en.wikipedia.org/wiki/Bengal_cat"
            });
            return cats;
        }
    }
}
