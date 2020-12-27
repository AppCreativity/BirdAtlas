import 'package:flutter_birdatlas/models.dart';
import 'package:flutter_birdatlas/services/birdatlasAPIInterface.dart';

class BirdAtlasAPIMocked extends BirdAtlasAPIInterface {
  List<Story> _stories;

  BirdAtlasAPIMocked() {
    _initStories();
  }

  Future<List<Story>> getStories() async {
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
  }
}
