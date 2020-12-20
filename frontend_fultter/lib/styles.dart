import 'dart:ui';
import 'package:flutter/material.dart';

enum ColorValue { dark, ligthBlue, warmBlue, darkBlue }

const AppColors = {
  ColorValue.dark: Color(0xFF262D3A),
  ColorValue.ligthBlue: Color(0xFF6688FF),
  ColorValue.warmBlue: Color(0x3D60DB),
  ColorValue.darkBlue: Color(0xFF1235B2)
};

//TODO: Glenn - read https://flutter.dev/docs/cookbook/design/themes
const TitleTextStyle = TextStyle(
    color: Colors.black,
    fontFamily: 'Montserrat',
    fontWeight: FontWeight.w700,
    fontSize: 18);
