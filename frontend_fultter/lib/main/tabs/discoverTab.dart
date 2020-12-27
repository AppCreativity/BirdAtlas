import 'package:flutter/material.dart';
import 'package:fultter_birdatlas/main/tabs/tabAppBar.dart';

class DiscoverTab extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: TabAppBar('Discover'),
      body: DiscoverBody(),
    );
  }
}

class DiscoverBody extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: EdgeInsets.fromLTRB(20.0, 0.0, 20.0, 0),
      child: ListView(
        children: <Widget>[
          CategoryHeaderListItem('Stories'),
          StoriesListItem()
        ],
      ),
    );
  }
}

class CategoryHeaderListItem extends StatelessWidget {
  final String category;

  CategoryHeaderListItem(this.category);

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      children: <Widget>[
        Text(category),
        InkWell(
          child: Text('Show all'),
          onTap: () => print('Tap - Show all'),
        )
      ],
    );
  }
}

class StoriesListItem extends StatelessWidget {
  final stories = [
    'Why we need to save the scavengers?',
    'Drunk birds? What is happening...',
    'The great travel, following the winter migration.'
  ];

  @override
  Widget build(BuildContext context) {
    return SizedBox(
        height: 200,
        child: ListView.builder(
            scrollDirection: Axis.horizontal,
            itemCount: stories.length,
            itemBuilder: (context, index) {
              return Container(child: Text(stories[index]));
            }));
  }
}
