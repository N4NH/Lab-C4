# LAB THỰC HÀNH – CHƯƠNG 4: AUDIO & VIDEO (UNITY)

---

## ✅ Lab 2 – Audio 2D vs 3D (Spatial Audio)

### Khi nào dùng âm thanh 2D?

Âm thanh **2D** nên dùng trong các trường hợp:

- Nhạc nền (**background music**)
- Âm thanh giao diện (**bấm nút, mở menu**)
- Thông báo hệ thống, âm thanh không phụ thuộc vị trí trong bản đồ

---

### Khi nào dùng âm thanh 3D?

Âm thanh **3D** nên dùng khi cần mô phỏng không gian và khoảng cách:

- Tiếng bước chân nhân vật trong thế giới game
- Tiếng súng, tiếng nổ, tiếng xe, tiếng mưa trong một khu vực cụ thể
- NPC nói chuyện ở vị trí cụ thể
- Bất kỳ âm thanh nào cần có **khoảng cách** và **hướng phát ra**

---

## ✅ Lab 4 – AudioClip Import & Optimization

### Mục tiêu

Tối ưu **bộ nhớ** và **hiệu năng** khi phát âm thanh trong Unity bằng cách cấu hình đúng:

- Load Type  
- Compression Format  

---

### 🎵 BGM (bgm.mp3)

- **Load Type:** Streaming  
- **Compression Format:** Vorbis  
- **Quality:** 70  

**Lý do:**  
Nhạc nền thường dài, dùng Streaming giúp Unity không phải nạp toàn bộ file vào RAM, giảm tốn bộ nhớ khi chạy game lâu.

---

### 🔊 SFX (jump.wav, click.wav)

- **Load Type:** Decompress On Load  
- **Compression Format:** PCM  

**Lý do:**  
Hiệu ứng âm thanh ngắn cần phản hồi ngay khi người chơi bấm hoặc phát sinh hành động.  
Decompress On Load + PCM giúp giảm độ trễ và giữ chất lượng tốt.

---

### (Nếu có) SFX dài hoặc ít quan trọng

- **Load Type:** Compressed In Memory  
- **Compression:** ADPCM / Vorbis  

**Lý do:**  
Ưu tiên giảm dung lượng, chấp nhận độ trễ nhỏ khi phát.

---

## 📌 Hình ảnh minh họa


---

### Lab 4 Import Settings

!![image](https://github.com/user-attachments/assets/1018a97e-69a1-492d-8402-19b661ea5db1)

![image](https://github.com/user-attachments/assets/53117657-7465-4a4a-b6a2-e6a15a49d475)


---


## Mô tả kết quả và nhận xét sau khi hoàn thành Lab Audio & Video

### Sau khi hoàn thành lab chương 4, em đã thực hiện được đầy đủ các yêu cầu về hệ thống Audio và Video trong Unity. Ở phần Audio, em đã tạo được AudioSource phát âm thanh theo phím điều khiển, phân biệt rõ âm thanh 2D và 3D thông qua Spatial Blend, đồng thời điều khiển âm thanh toàn cục bằng chức năng mute và pause. Ngoài ra, em cũng import và tối ưu nhiều AudioClip bằng cách chọn Load Type và Compression phù hợp cho nhạc nền (BGM) và hiệu ứng âm thanh (SFX).

### Ở phần Video, em đã import video mp4 và sử dụng VideoPlayer để phát video trong scene. Video được hiển thị đúng qua RenderTexture và RawImage trên UI cũng như trên object 3D. Em cũng đã áp dụng sự kiện prepareCompleted và loopPointReached để xử lý khi video kết thúc, hiển thị UI hoặc chuyển scene tự động. Cuối cùng, mini project intro cutscene hoạt động đúng với video intro, nhạc nền, nút skip và tự chuyển vào gameplay.

### Nhận xét chung, lab này giúp em hiểu rõ hơn cách Unity quản lý âm thanh và video trong game, đồng thời thấy được tầm quan trọng của việc tối ưu tài nguyên để đảm bảo hiệu năng. Đây là kiến thức nền tảng cần thiết để xây dựng trải nghiệm game sinh động và chuyên nghiệp hơn.



# File gg Driver chứa Video
## https://drive.google.com/drive/folders/1O4aEYlTgg3cgEO_gfurC-NATHJMLJuin?usp=sharing

