import 'package:flutter/material.dart';
import 'package:flutter_birdatlas/models.dart';

abstract class BirdAtlasAPIInterface extends ChangeNotifier {
  Future<List<Story>> getStories();
  Future<Story> getStory(int id);
}
