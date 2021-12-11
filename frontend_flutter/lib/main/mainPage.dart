import 'package:flutter/material.dart';
import 'package:flutter_birdatlas/main/tabs/bookmarkTab.dart';
import 'package:flutter_birdatlas/main/tabs/discoverTab.dart';
import 'package:flutter_birdatlas/main/tabs/searchTab.dart';
import 'package:flutter_birdatlas/models.dart';
import 'package:flutter_birdatlas/styles.dart';

class MainPage extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => _MainPageState();
}

class _MainPageState extends State<MainPage> {
  int _selectedTabIndex = 0;

  static List<Widget> _tabs = <Widget>[
    DiscoverTab(),
    SearchTab(),
    BookMarkTab(),
  ];

  void _onItemTapped(int index) {
    setState(() {
      _selectedTabIndex = index;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Center(
        child: _tabs.elementAt(_selectedTabIndex),
      ),
      bottomNavigationBar: BottomNavigationBar(
        items: const <BottomNavigationBarItem>[
          BottomNavigationBarItem(
            icon: Icon(Icons.home),
            label: '',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.business),
            label: '',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.school),
            label: '',
          ),
        ],
        currentIndex: _selectedTabIndex,
        selectedItemColor: AppColors[ColorValue.ligthBlue],
        showSelectedLabels: false,
        showUnselectedLabels: false,
        onTap: _onItemTapped,
      ),
    );
  }
}
