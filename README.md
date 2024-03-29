Olvashatóságért válts Code nézetre
Hátra van még:
-Kategória szerinti szűrés (azt még majd megcsinálom)
-"A listából lehessen kiválasztani egy autót, amely esetén megnézhető, hogy melyik napokon lehetséges a bérlés"
-"Az autót lehessen lefoglalni, amely során megadható a bérlés kezdő és végdátuma, amely
  alapján a rendszer számítja a várható költséget, valamint ellenőrzi, hogy a megadott
  időszakban valóban szabad-e az autó és csak ez esetben hajtja végre a tényleges foglalást."
-"A felhasználó legyen képes listázni a korábbi kölcsönzéseit"
-"A rendszer biztosítson egy funkciót, amely a felhasználót informálja az akciós ajánlatokról."

<OsztályNév>Controller.cs-be kerül a program fő logikája, az alapot a server-cliens kommunikációt mellőzve is meglehet csinálni, cliens-be többnyire csak a fogadás van , egy két kivétellel (pl.: Login)
Cliens kód a MainWIndow.xaml.cs-ben található, fő elemei:
  HttpResponseMessage response = await _client.GetAsync("https://localhost:7173/api/Car-listCars"); // _client.(Get vagy Post a szerveroldali metódustól függöen)Async(...);
  response.EnsureSuccessStatusCode();    //csatlakozás ellenörzés
      
  string responseBody = await response.Content.ReadAsStringAsync();
  List<Car> cars = JsonSerializer.Deserialize<List<Car>>(responseBody);   //JSON fájl-t alakitja vissza C#-os adattá
  függvények láthatósága után "async" kulcsszó
