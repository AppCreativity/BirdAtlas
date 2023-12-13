import 'package:flutter_birdatlas/models.dart';
import 'package:flutter_birdatlas/services/birdatlasAPIInterface.dart';

class BirdAtlasAPIMocked extends BirdAtlasAPIInterface {
  late List<Story> _stories;

  BirdAtlasAPIMocked() {
    _initStories();
  }

  Future<List<Story>> getStories() async {
    //TODO: Glenn - dummy delay to test the async loading
    return Future.delayed(Duration(seconds: 5)).then((value) => _stories);
  }

  Future<Story> getStory(int id) async {
    throw UnimplementedError();
  }

  void _initStories() {
    _stories = {
      Story()
        ..id = 1
        ..title = 'Why we need to save the scavengers?'
        ..category = 'The Wilds'
        ..image = 'https://placekitten.com/800/600',
      Story()
        ..id = 2
        ..title = 'Drunk birds? What is happening...'
        ..category = 'Science'
        ..image = 'https://placekitten.com/800/600',
      Story()
        ..id = 3
        ..title = 'Follow the great winter migration.'
        ..category = 'Science'
        ..image = 'https://placekitten.com/800/600',
      Story()
        ..id = 4
        ..title = 'Follow the great winter migration.'
        ..category = 'Science'
        ..image = 'https://placekitten.com/800/600',
      Story()
        ..id = 5
        ..title = 'Follow the great winter migration.'
        ..category = 'Science'
        ..image = 'https://placekitten.com/800/600',
      Story()
        ..id = 6
        ..title = 'Follow the great winter migration.'
        ..category = 'Science'
        ..image = 'https://placekitten.com/800/600',
    }.toList();
  }
}
