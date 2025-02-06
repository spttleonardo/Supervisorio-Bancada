#include "max6675.h" //INCLUSÃO DE BIBLIOTECA
#include <Adafruit_MAX31856.h>


//----MAX31785---------
#define SDIPIN 8 // DEFINE SDI NO PINO 8 ( MISO)
#define SCKPIN 9 // DEFINE SCK NO PINO  9( CLOCK)
#define SDOPIN 10 // DEFINE SDI NO PINO  10 ( MOSI)
#define CSPIN 11 // DEFINE CS NO PINO 12 (CHIP SELECT)

Adafruit_MAX31856 maxthermo = Adafruit_MAX31856(11, 8, 10, 9);
// Use software SPI: CS, DI, DO, CLK


//----MAX6675------
int ktcSO = 5; //PINO DIGITAL (SO)
int ktcCS = 6; //PINO DIGITAL (CS)
int ktcCLK = 7; //PINO DIGITAL (CLK / SCK)
//--------------

MAX6675 ktc(ktcCLK, ktcCS, ktcSO); //CRIA UMA INSTÂNCIA UTILIZANDO OS PINOS (CLK, CS, SO)


void setup() {
 
   Serial.begin(9600); //INICIALIZA A SERIAL

  if (!maxthermo.begin()) {
    Serial.println("Could not initialize thermocouple.");
    while (1) delay(10);
  }

  maxthermo.setThermocoupleType(MAX31856_TCTYPE_K);


  maxthermo.setConversionMode(MAX31856_ONESHOT_NOWAIT);
  delay(200);
   
}

void loop() {

 maxthermo.triggerOneShot();
 
 delay(200); // replace this with whatever
 Serial.print(maxthermo.readThermocoupleTemperature());
 Serial.print(",");
 Serial.println(ktc.readCelsius());
 
}
