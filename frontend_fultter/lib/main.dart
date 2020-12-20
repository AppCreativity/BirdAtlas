import 'package:flutter/material.dart';
// import 'package:flutter/services.dart';
import 'package:fultter_birdatlas/main/mainPage.dart';

void main() {
  // SystemChrome.setSystemUIOverlayStyle(SystemUiOverlayStyle(
  //   systemNavigationBarColor: Colors.white, // navigation bar color
  //   statusBarColor: Colors.white, // status bar color
  //   statusBarBrightness: Brightness.light, //status bar brigtness
  //   statusBarIconBrightness: Brightness.light, //status barIcon Brightness
  //   systemNavigationBarDividerColor:
  //       Colors.greenAccent, //Navigation bar divider color
  //   systemNavigationBarIconBrightness: Brightness.light,
  // )); //navigation bar icon
  runApp(BirdAtlasApp());
}

class BirdAtlasApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Bird Atlas',
      theme: ThemeData(
        primarySwatch: Colors.blue,
        visualDensity: VisualDensity.adaptivePlatformDensity,
      ),
      //home: SafeArea(child: MainPage()), //SafeArea not needed, the AppBar takes care of it
      home: MainPage(),
      debugShowCheckedModeBanner: false,
    );
  }
}
