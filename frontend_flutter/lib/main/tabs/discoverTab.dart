import 'package:flutter/material.dart';
import 'package:flutter_birdatlas/main/tabs/tabAppBar.dart';
import 'package:flutter_birdatlas/models.dart';
import 'package:flutter_birdatlas/services/birdatlasAPIInterface.dart';
import 'package:flutter_birdatlas/styles.dart';
import 'package:get_it/get_it.dart';

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
    return ListView(
      children: <Widget>[
        CategoryHeader('Stories'),
        StoriesList(),
        CategoryHeader('Habitats'),
        HabitatList(),
        CategoryHeader('Nearby'),
      ],
    );
  }
}

class CategoryHeader extends StatelessWidget {
  final String category;

  CategoryHeader(this.category);

  @override
  Widget build(BuildContext context) {
    return Padding(
        padding: EdgeInsets.fromLTRB(20.0, 10.0, 20.0, 0.0),
        child: Row(
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
        ));
  }
}

class StoriesList extends StatefulWidget {
  @override
  State<StatefulWidget> createState() => _StoriesListState();
}

class _StoriesListState extends State<StoriesList> {
  List<Story> _stories;

  BirdAtlasAPIInterface get service => GetIt.instance<BirdAtlasAPIInterface>();

  @override
  void initState() {
    _getStories();
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    if (_stories == null)
      return Text('Loading....');
    else {
      return SizedBox(
          height: 200,
          child: ListView.builder(
              padding: EdgeInsets.fromLTRB(0.0, 10.0, 0.0, 10.0),
              scrollDirection: Axis.horizontal,
              itemCount: _stories.length,
              itemBuilder: (context, index) {
                bool last = _stories.length == (index + 1);
                return StoryListItem(_stories[index], last);
              }));
    }
  }

  void _getStories() async {
    _stories = await service.getStories();
    setState(() {});
  }
}

class StoryListItem extends StatelessWidget {
  final Story story;
  bool last;

  StoryListItem(this.story, this.last);

  @override
  Widget build(BuildContext context) {
    return Container(
        width: 200,
        margin: last
            ? EdgeInsets.fromLTRB(20.0, 0.0, 20.0, 0.0)
            : EdgeInsets.only(left: 20.0),
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
              bool last = habitats.length == (index + 1);
              return HabitatListItem(habitats[index], last);
            }));
  }
}

class HabitatListItem extends StatelessWidget {
  final Habitat habitat;
  bool last;

  HabitatListItem(this.habitat, this.last);

  @override
  Widget build(BuildContext context) {
    return Container(
      width: 160,
      margin: last
          ? EdgeInsets.fromLTRB(20.0, 0.0, 20.0, 0.0)
          : EdgeInsets.only(left: 20.0),
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