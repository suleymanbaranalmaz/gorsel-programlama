-- ATOTIFY GERÇEK ZAMANLI VERİTABANI SORGUSU
-- Tüm tabloları ve anlık dinleme verilerini görmek için bu sorguyu çalıştırın (F5 veya Execute).

USE AtotifyDB;
GO

SELECT '=== 1. ANLIK DİNLEME GEÇMİŞİ (Kim Ne Dinliyor?) ===' AS [BİLGİ];
SELECT TOP 50
    ph.PlayedAt AS [Dinlenme Zamanı],
    u.Username AS [Kullanıcı],
    s.Title AS [Şarkı],
    s.Artist AS [Sanatçı]
FROM PlayHistories ph
INNER JOIN Users u ON ph.UserId = u.Id
INNER JOIN Songs s ON ph.SongId = s.Id
ORDER BY ph.PlayedAt DESC;

SELECT '=== 2. OLUŞTURULAN ÇALMA LİSTELERİ ===' AS [BİLGİ];
SELECT 
    p.Name AS [Liste Adı],
    u.Username AS [Oluşturan],
    (SELECT COUNT(*) FROM PlaylistSongs ps WHERE ps.PlaylistId = p.Id) AS [Şarkı Sayısı],
    p.CreatedAt AS [Oluşturulma Tarihi]
FROM Playlists p
INNER JOIN Users u ON p.UserId = u.Id;

SELECT '=== 3. SİSTEMDEKİ KULLANICILAR ===' AS [BİLGİ];
SELECT Id, Username, Email, CreatedAt AS [Kayıt Tarihi] FROM Users;

SELECT '=== 4. SİSTEMDE KAYITLI TÜM ŞARKILAR ===' AS [BİLGİ];
SELECT Id, Title AS [Şarkı], Artist AS [Sanatçı] FROM Songs;

