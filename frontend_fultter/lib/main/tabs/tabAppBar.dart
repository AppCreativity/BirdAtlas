import 'package:flutter/material.dart';
import 'package:fultter_birdatlas/styles.dart';

class TabAppBar extends StatefulWidget implements PreferredSizeWidget {
  final String title;

  TabAppBar(this.title, {Key key})
      : preferredSize = Size.fromHeight(kToolbarHeight),
        super(key: key);

  @override
  final Size preferredSize; // default is 56.0

  @override
  _TabAppBarState createState() => _TabAppBarState(title);
}

class _TabAppBarState extends State<TabAppBar> {
  final String title;

  _TabAppBarState(this.title);

  @override
  Widget build(BuildContext context) {
    return AppBar(
      elevation: 0, //Remove the shadow line
      backgroundColor: Colors.transparent,
      brightness: Brightness.light,
      actionsIconTheme: IconThemeData(size: 20.0, color: Colors.black),
      actions: [
        Padding(
            padding: EdgeInsets.only(right: 20.0),
            child: GestureDetector(
                onTap: () {}, //TODO: Glenn - handle settings tap
                child: Icon(
                  Icons.tune,
                )))
      ],
      title: Text(title, style: TitleTextStyle),
    );
  }
}
