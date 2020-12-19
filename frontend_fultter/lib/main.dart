import 'package:flutter/material.dart';
import 'package:fultter_birdatlas/main/mainPage.dart';

void main() {
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
      home: SafeArea(child: MainPage()),
      debugShowCheckedModeBanner: false,
    );
  }
}
