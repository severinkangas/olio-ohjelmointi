Tehtävä 5.1 (2pts)
Tehtävänäsi on toteuttaa auton logiikka, pohjana voi käyttää 4.2 toteutusta.
Suunnittele ja toteuta tarvittavat jäsenmuuttujat jolla kontrolloit auton tilaa, niin että
alla olevista metodeista tulee järkevä kokonaisuus. Esim. ennen kiihdytystä
tarkistetaan että onko tarpeeksi polttoainetta ja moottori käynnissä. Tässä
tehtävässä kannattaa miettiä miten auto oikeasti toimii.
Luo seuraavat julkiset metodit
startCar
accelerate
brake
maxSpeed
stopEngine
lockDoor
Ja seuraavat yksityiset metodit
checkFuel
engineStarted
doorsOpen
Pääohjelmassa luo auto olio, kiihdytä autoa toistolausekkeessa niin kauaa että
maksimi nopeus on saavutettu jonka jälkeen jarruta, sammuta moottori ja laita ovet
lukkoon. Maksiminopeuden voit itse määrittää. Kiinnitä huomiota siihen, että autoon
liittyvät tiedot on tallessa auto oliossa.