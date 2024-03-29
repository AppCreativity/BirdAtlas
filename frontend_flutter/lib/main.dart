import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter_birdatlas/services/birdatlasAPIInterface.dart';
import 'package:flutter_birdatlas/services/birdatlasAPIMocked.dart';
import 'package:flutter_birdatlas/main/mainPage.dart';
import 'package:get_it/get_it.dart';

GetIt getIt = GetIt.instance;

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

  getIt
      .registerLazySingleton<BirdAtlasAPIInterface>(() => BirdAtlasAPIMocked());

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
        appBarTheme: AppBarTheme(
            systemOverlayStyle: SystemUiOverlayStyle
                .dark), // https://sarunw.com/posts/how-to-change-status-bar-text-color-in-flutter/
      ),
      //home: SafeArea(child: MainPage()), //SafeArea not needed, the AppBar takes care of it
      home: MainPage(),
      debugShowCheckedModeBanner: false,
    );
  }
}
