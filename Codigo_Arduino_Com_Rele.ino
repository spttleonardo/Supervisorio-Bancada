
// Declaração de variaveis 
const int solenoide = 2; // declara solenoide no pino 2
const int cooler_interno = 3; //declara cooler interno no pino 3 
const int cooler_externo = 4; // declara cooler externo no pino 4
const int controlador = 5; // declara controlador no pino 5
int seg = 0,valor2=0,valor=0;
String estado;


void setup()
{
  Serial.begin(9600);
 
  
 
  TCCR1A = 0;  // Limpa o Registrador que configura o TIMER1
           // O três primeiros bits dizem a respeito ao PWM    
  
  TCCR1B = 0; // Limpa o Registrador que configura o TIMER1
          // Os três ultimos pinos dizem a respeito ao prescale
  
  TCCR1B |= (1<<CS10)|(1 << CS12);   // configura prescaler para 1024 com o bit 1 setado em CS12 e CS10
 
  TCNT1 = 0xC2F7;             // incia timer com valor para que estouro ocorra em 1 segundo
                                     // 65536-(16MHz/1024/60Hz) = 12589 = 0x312D
  
  TIMSK1 |= (1 << TOIE1);           // habilita a interrupção do TIMER1 com o bit 1 setado no TOIE1

  pinMode(solenoide, OUTPUT);
  digitalWrite(solenoide,HIGH);
  pinMode(cooler_interno, OUTPUT);
  digitalWrite(cooler_interno, HIGH);
  pinMode(cooler_externo, OUTPUT);
  digitalWrite(cooler_externo,HIGH);
  pinMode(controlador,OUTPUT);
  digitalWrite(controlador,OUTPUT);
}

void loop()
{

   if(Serial.available() > 0){ 
         estado = Serial.read(); // lê porta serial 
         valor = estado.toInt(); // converter uma variavel char para um variavel do tipo int 
         delay(10);

           if(  valor > 41 ){
                valor2 = valor;
                valor = valor * 0;
              }
              
           if( valor == 37 ){// liga cooler interno %
               digitalWrite(cooler_interno,LOW);
              }
           if(valor == 38){ // desliga cooler interno &
               digitalWrite(cooler_interno,HIGH);
              }
           if(valor == 33){ // liga solenoide !
              digitalWrite(solenoide,LOW);
              }
           if(valor == 41){ // desliga oooler externo com o caracter )
             digitalWrite(cooler_externo,HIGH);
             }
           if(valor == 36){//liga cooler externo com o caracter $ 
             digitalWrite(cooler_externo, LOW);
             }
           if(valor == 39){ // desliga controlador '
             digitalWrite(controlador,HIGH);
             }
           if(valor == 40){ // liga controlador (
             digitalWrite(controlador, LOW);
             }
           if(valor == 35){ // desliga solenoide #
              digitalWrite(solenoide,HIGH);
              valor2= valor2*0;
              seg = seg* 0;
             }
       }
 
     if(valor2 == 48 || valor2 == 47 ){
       seg = seg*0;
       valor2 = valor2*0;
       }
 
}



ISR(TIMER1_OVF_vect)//interrupção do TIMER1 setado para acionamento a cada 4 min 
{
  if( valor2 >48 && valor2<=58 ){ // começa a contagem do time com valor>1 e valor<=10
    seg ++;
  }
  
  if( seg == 240){ 
    digitalWrite(solenoide,LOW);
    valor2 = valor2 - 1;
  }
  
  if( seg == 480){
    digitalWrite(solenoide,HIGH);
    valor2 = valor2 - 1;
    seg = seg * 0;
  }
 
  TCNT1 = 0xC2F7; // Renicia TIMER
 
}
