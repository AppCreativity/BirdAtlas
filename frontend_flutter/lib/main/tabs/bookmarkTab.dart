import 'package:flutter/material.dart';
import 'package:flutter_birdatlas/main/tabs/tabAppBar.dart';

class BookMarkTab extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: TabAppBar('Bookmarked'),
      body: Text('Index 2: School'),
    );
  }
}
