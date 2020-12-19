import 'package:flutter/material.dart';
import 'package:fultter_birdatlas/main/tabs/tabAppBar.dart';

class DiscoverTab extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: TabAppBar('Discover'),
      body: Text('Index 0: Home'),
    );
  }
}
