----Factory Pattern Nedir?

Unity'de Factory Pattern'i, oyun nesnelerinin (GameObject) veya bileşenlerin oluşturulmasını merkezi bir yerden yönetmek için kullanılan yaygın bir Design Patterndir. 

![Movie_003-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/04e4397a-c118-4fa0-8796-5405d63aabba)

Projede basit bir şekilde örneklendirilmiştir. Mouse sol tık ile Factroy pattern yapısı kullanarak sırası ile sphere veya capsule yaratır.
Mouse sağ tık ile ilk yaratılandan silmeye başlar.




----Command Pattern Nedir?

Command Pattern, bir işlemi (örneğin bir butona basmak veya bir menü seçeneğini çalıştırmak) bir nesne olarak temsil eder. Bu sayede:

İşlemleri kolayca değiştirilebilir, yeniden düzenlenebilir veya geri alınabilir hale getirir.
İşlemleri bir kuyruğa ekleyebilir veya farklı zamanlarda çalıştırabilirsiniz.
Kodunuzu daha modüler ve test edilebilir hale getirir.


https://github.com/user-attachments/assets/802bbdf5-7216-4d5f-8f2f-7de09145cd5f


Projede bir top farklı yönlerde buttonlar vasıtası ile hareket etmektedir ayrıca undo ve redo işlemleri buttonlar aracılığıyla çalışmaktadır.
Command patternin basit bir örneği


----State Pattern Nedir?
State Pattern, bir nesnenin iç durumuna göre davranışını değiştirmesini sağlayan bir desing patterndir. Bu desen, "bir nesnenin durumu değiştiğinde davranışının da otomatik olarak değişmesini" hedefler.
Örneğin, bir karakterin oyun içinde "yürürken", "koşarken", "zıplarken" veya "beklerken" farklı davranışlar sergilemesi gibi senaryolarda kullanılabilir.

State Pattern'in temel fikri, her durumu ayrı bir sınıf olarak tanımlamak ve bu sınıfların ortak bir arayüz üzerinden iletişim kurmasını sağlamaktır.
Böylece, bir nesne durum değiştirdiğinde, ilgili durum sınıfı devreye girer ve gerekli işlemleri gerçekleştirir.



https://github.com/user-attachments/assets/efe277df-4df0-48da-80b2-d6b545fa039d

Projede yapılabilecek eylemler statelere ayrılmıştır ve eylermeri stateler yönetmektedir.

