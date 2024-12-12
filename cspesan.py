import pyautogui
import time
def kirim_pesan_cs2(pesan, jumlah, interval):
    time.sleep(5)  
    for i in range(jumlah):
        pyautogui.press("y")  
        pyautogui.typewrite(pesan) 
        pyautogui.press("enter")  
        time.sleep(interval)  

pesan = "666 xi jinping idiot"


jumlah_pengiriman = 100
interval_waktu = 0.01  

kirim_pesan_cs2(pesan, jumlah_pengiriman, interval_waktu)