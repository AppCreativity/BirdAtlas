import 'package:flutter/material.dart';
import 'package:fultter_birdatlas/main/tabs/tabAppBar.dart';

class SearchTab extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: TabAppBar('Search'),
      body: Text('Index 1: Business'),
    );
  }
}
