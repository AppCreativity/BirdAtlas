import 'package:flutter/material.dart';
import 'package:fultter_birdatlas/main/tabs/tabAppBar.dart';
import 'package:fultter_birdatlas/models.dart';
import 'package:fultter_birdatlas/styles.dart';

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
          CategoryHeader('Stories'),
          StoriesList(),
          Padding(
              padding: EdgeInsets.fromLTRB(0.0, 10.0, 0.0, 0.0),
              child: CategoryHeader('Habitats')),
          HabitatList(),
          Padding(
              padding: EdgeInsets.fromLTRB(0.0, 10.0, 0.0, 0.0),
              child: CategoryHeader('Nearby')),
        ],
      ),
    );
  }
}

class CategoryHeader extends StatelessWidget {
  final String category;

  CategoryHeader(this.category);

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.spaceBetween,
      children: <Widget>[
        Text(
          category,
          style: categoryTextStyle,
        ),
        InkWell(
          child: Text(
            'Show all',
            style: categoryLinkTextStyle,
          ),
          onTap: () => print('Tap - Show all'),
        )
      ],
    );
  }
}

class StoriesList extends StatelessWidget {
  final stories = {
    Story()
      ..id = 1
      ..title = 'Why we need to save the scavengers?'
      ..category = 'The Wilds'
      ..image =
          'https://www.birdlife.org/sites/default/files/styles/slider_image/public/slider/arcticternb1_markus_varesvuo-2.jpg',
    Story()
      ..id = 2
      ..title = 'Drunk birds? What is happening...'
      ..category = 'Science'
      ..image =
          'https://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/little_spiderhunter_c_noicherrybeans_shutterstock_smaller_1.jpg',
    Story()
      ..id = 3
      ..title = 'Follow the great winter migration.'
      ..category = 'Science'
      ..image =
          'https://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/canada_warbler_c_jayne_gulbrand_smaller.jpg',
    Story()
      ..id = 4
      ..title = 'Follow the great winter migration.'
      ..category = 'Science'
      ..image =
          'https://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/canada_warbler_c_jayne_gulbrand_smaller.jpg',
  }.toList();

  @override
  Widget build(BuildContext context) {
    return SizedBox(
        height: 200,
        child: ListView.builder(
            padding: EdgeInsets.fromLTRB(0.0, 10.0, 0.0, 10.0),
            scrollDirection: Axis.horizontal,
            itemCount: stories.length,
            itemBuilder: (context, index) {
              return StoryListItem(stories[index]);
            }));
  }
}

class StoryListItem extends StatelessWidget {
  final Story story;

  StoryListItem(this.story);

  @override
  Widget build(BuildContext context) {
    return Container(
        width: 200,
        margin: EdgeInsets.only(right: 20.0),
        decoration: BoxDecoration(
          color: Colors.white,
          borderRadius: BorderRadius.circular(8.0),
          boxShadow: [
            BoxShadow(
              color: Colors.grey.withOpacity(0.15),
              spreadRadius: 2.0,
              blurRadius: 6.5,
              offset: Offset(3, 3),
            ),
          ],
          image: DecorationImage(
            alignment: Alignment.topCenter,
            image: NetworkImage(story.image),
            fit: BoxFit.fitWidth,
          ),
        ),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Spacer(
              flex: 6,
            ),
            Expanded(
                flex: 4,
                child: Padding(
                    padding: EdgeInsets.fromLTRB(10.0, 0.0, 10.0, 0.0),
                    child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Padding(
                              padding: EdgeInsets.only(bottom: 5.0),
                              child: Text(
                                story.category,
                                style: storyCategoryTextStyle,
                              )),
                          Text(
                            story.title,
                            style: storyTitleTextStyle,
                          )
                        ])))
          ],
        ));
  }
}

class HabitatList extends StatelessWidget {
  final habitats = {
    Habitat()
      ..name = 'Forests'
      ..type = HabitatType.Forest
      ..amount = 290,
    Habitat()
      ..name = 'Tundra'
      ..type = HabitatType.Tundra
      ..amount = 311,
    Habitat()
      ..name = 'Deserts'
      ..type = HabitatType.Desert
      ..amount = 307
  }.toList();

  @override
  Widget build(BuildContext context) {
    return SizedBox(
        height: 100,
        child: ListView.builder(
            padding: EdgeInsets.fromLTRB(0.0, 10.0, 0.0, 10.0),
            scrollDirection: Axis.horizontal,
            itemCount: habitats.length,
            itemBuilder: (context, index) {
              return HabitatListItem(habitats[index]);
            }));
  }
}

class HabitatListItem extends StatelessWidget {
  final Habitat habitat;

  HabitatListItem(this.habitat);

  @override
  Widget build(BuildContext context) {
    return Container(
      width: 160,
      margin: EdgeInsets.only(right: 20.0),
      decoration: BoxDecoration(
        color: habitat.color,
        borderRadius: BorderRadius.circular(8.0),
      ),
      child: Padding(
          padding: EdgeInsets.fromLTRB(10.0, 0.0, 0.0, 0.0),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Expanded(
                  flex: 2,
                  // child: Align(
                  //     alignment: Alignment.topLeft, child: Text(habitat.name))),
                  child: Padding(
                      padding: EdgeInsets.only(top: 10.0),
                      child: Text(habitat.name, style: habitatTitleTextStyle))),
              Expanded(
                flex: 1,
                child: Text(habitat.amount.toString() + ' birds',
                    style: habitatDescriptionTextStyle),
              )
            ],
          )),
    );
  }
}
