import 'dart:ui';

import 'package:flutter_birdatlas/styles.dart';

enum ColorValue { dark, ligthBlue, warmBlue, darkBlue }

enum HabitatType {
  Forest,
  Grassland,
  Tundra,
  Desert,
  Wetland,
  Ocean,
  UrbanSuburban
}

class Story {
  int id;
  String title;
  String category;
  String author;
  String image;
  bool isFeatured;
}

class Habitat {
  String name;
  HabitatType type;
  int amount;
  Color get color {
    switch (type) {
      case HabitatType.Grassland:
      case HabitatType.Tundra:
        return AppColors[ColorValue.warmBlue];
      case HabitatType.Forest:
      case HabitatType.Wetland:
      case HabitatType.UrbanSuburban:
        return AppColors[ColorValue.ligthBlue];
      case HabitatType.Desert:
      case HabitatType.Ocean:
        return AppColors[ColorValue.darkBlue];
    }
  }
}

class Nearby {
  String image;
  String name;
}

/*
// In Dart it is not needed to wrap fields into get/set if the getter and setters don't add value
class ToDo {
    String _title;
    bool _done;

    String get title => _title;
    void set title(String newTitle) { _title = newTitle; }

    bool get _done => _done
    void set done(bool done) { _done = done; }
}
*/
