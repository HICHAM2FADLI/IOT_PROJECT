/* 
* Pin layout should be as follows (on Arduino Uno):
* MOSI: Pin 11 / ICSP-4
* MISO: Pin 12 / ICSP-1
* SCK: Pin 13 / ISCP-3
* SS/SDA: Pin 10
* RST: Pin 9
*/

#include <SPI.h>
#include <RFID.h>


#define SS_PIN 10
#define RST_PIN 9

RFID rfid(SS_PIN,RST_PIN);


 

void setup(){

    Serial.begin(9600);
    SPI.begin();
    rfid.init();    
    pinMode(6, OUTPUT);
   
}

void loop(){
    String rid = "";
    
    if(rfid.isCard()){
    
        if(rfid.readCardSerial()){ 
              for(int i=0;i<sizeof(rfid.serNum);i++)
              {
              rid +=  String(rfid.serNum[i],DEC);
              //Serial.print(RC522.serNum[i],HEX); //to print card detail in Hexa Decimal format
              } 
              Serial.print(rid);
 
                tone(6,3000);
                delay(250); 
                 noTone(6);      
        }
        
        
    }
    
    
    delay(1000);
    rfid.halt();

}
