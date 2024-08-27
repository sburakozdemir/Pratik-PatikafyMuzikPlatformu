using Pratik_PatikafyMuzikPlatformu;

List<Patikafy> sanatcilar = new List<Patikafy>
            {
                new Patikafy("Ajda Pekkan", "Pop", 1968, 20),
                new Patikafy("Sezen Aksu", "Türk Halk Müziği / Pop", 1971, 10),
                new Patikafy("Funda Arar", "Pop", 1999, 3),
                new Patikafy("Sertab Erener", "Pop", 1994, 5),
                new Patikafy("Sıla", "Pop", 2009, 3),
                new Patikafy("Serdar Ortaç", "Pop", 1994, 10),
                new Patikafy("Tarkan", "Pop", 1992, 40),
                new Patikafy("Hande Yener", "Pop", 1999, 7),
                new Patikafy("Hadise", "Pop", 2005, 5),
                new Patikafy("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10),
                new Patikafy("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2)
            };

// 1. Adı 'S' ile başlayan şarkıcılar
Console.WriteLine("Adı 'S' ile başlayan şarkıcılar:");
var sIleBaslayanlar = sanatcilar.Where(s => s.TamAD.StartsWith("S"));
foreach (var sanatci in sIleBaslayanlar)
{
    Console.WriteLine(sanatci.TamAD);
}

// 2. Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
Console.WriteLine("\nAlbüm satışları 10 milyon'un üzerinde olan şarkıcılar:");
var cokSatanlar = sanatcilar.Where(s => s.Satis > 10);
foreach (var sanatci in cokSatanlar)
{
    Console.WriteLine($"{sanatci.TamAD} - {sanatci.Satis} milyon");
}

// 3. 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar
Console.WriteLine("\n2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
var eskiPopSanatcilar = sanatcilar
    .Where(s => s.Yil < 2000 && s.Tur.Contains("Pop"))
    .OrderBy(s => s.Yil)
    .ThenBy(s => s.TamAD);
foreach (var sanatci in eskiPopSanatcilar)
{
    Console.WriteLine($"{sanatci.TamAD} - {sanatci.Yil}");
}

// 4. En çok albüm satan şarkıcı
var enCokSatan = sanatcilar.OrderByDescending(s => s.Satis).First();
Console.WriteLine($"\nEn çok albüm satan şarkıcı: {enCokSatan.TamAD} - {enCokSatan.Satis} milyon");

// 5. En yeni ve en eski çıkış yapan şarkıcılar
var enYeni = sanatcilar.OrderByDescending(s => s.Yil).First();
var enEski = sanatcilar.OrderBy(s => s.Yil).First();
Console.WriteLine($"\nEn yeni çıkış yapan şarkıcı: {enYeni.TamAD} - {enYeni.Yil}");
Console.WriteLine($"En eski çıkış yapan şarkıcı: {enEski.TamAD} - {enEski.Yil}");
