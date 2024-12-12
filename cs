import pyautogui
import time
def kirim_pesan_cs2(pesan, jumlah, interval):
    time.sleep(5)  
    for i in range(jumlah):
        pyautogui.press("y")  
        pyautogui.typewrite(pesan) 
        pyautogui.press("enter")  
        time.sleep(interval)  

pesan = "666 xi jinping idiot" #contoh pesan


jumlah_pengiriman = 100 # mau di kirim berapa kali pesannya
interval_waktu = 0.01  #selisih waktu kirim better di ganti ke 1

kirim_pesan_cs2(pesan, jumlah_pengiriman, interval_waktu)
