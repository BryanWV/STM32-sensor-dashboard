#include <Arduino.h>

#define LM35_PIN PF3 // Define ADC input for the sensor, which is the LM35
#define resolution 4095
#define input_voltage 5.0

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  pinMode(LM35_PIN, INPUT_ANALOG);
  analogReadResolution(12);
}

void loop() {
  // put your main code here, to run repeatedly:
  int adcValue = analogRead(LM35_PIN);
  float voltage = (adcValue * input_voltage) / resolution;
  float temperature = voltage * 100.0;

  Serial.print("Temperature: ");
  Serial.print(temperature);
  Serial.println(" C");
  delay(50);
}
