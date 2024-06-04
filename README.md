# UcakRezervasyonSistemi

Bu proje, uçak rezervasyon işlemlerini gerçekleştirebileceğiniz bir form uygulamadır. C# dilinde yazılmıştır. Kullanıcılar, uçuşları arayabilir, rezervasyon yapabilir ve mevcut rezervasyonlarını görüntüleyebilirler.

Proje Yapısı

Proje aşağıdaki ana dosya ve klasörlerden oluşmaktadır:

Models/: Uçuş, lokasyon ve rezervasyon bilgilerini içeren sınıfları içerir.

UcakRezervasyonContext.cs: Veri tabanı işlemlerini yöneten sınıf.

UcakRezervasyonContext.db: Veri tabanını temsil eden dosya.

Form1.cs: Uygulamanın ana arayüzünü içeren dosya.

Modeller

Ucak.cs

Bu sınıf, uçak bilgilerini temsil eder. Uçağın ID'si, model adı, kapasitesi gibi bilgileri içerir.

Lokasyon.cs

Bu sınıf, lokasyon bilgilerini temsil eder. Kalkış ve varış yerlerinin isimlerini ve kodlarını içerir.

Rezervasyon.cs

Bu sınıf, rezervasyon bilgilerini temsil eder. Rezervasyonun ID'si, kullanıcı bilgileri, uçuş ID'si ve rezervasyon tarihi gibi bilgileri içerir.

Veri Tabanı

UcakRezervasyonContext.cs, Entity Framework kullanarak veri tabanı işlemlerini yöneten sınıftır. Bu sınıf, uçuş, lokasyon ve rezervasyon tablolarını içerir ve gerekli CRUD (Create, Read, Update, Delete) işlemlerini gerçekleştirir.

Arayüz

Form1.cs, kullanıcı etkileşimlerini yöneten ve arayüz bileşenlerini içeren sınıftır. Kullanıcıların uçuş araması yapmasını, rezervasyon oluşturmasını ve mevcut rezervasyonları görüntülemesini sağlar.
