import 'dart:ui';
import 'package:flutter/material.dart';
import 'package:flutter_birdatlas/models.dart';

const AppColors = {
  ColorValue.dark: Color(0xFF262D3A),
  ColorValue.ligthBlue: Color(0xFF6688FF),
  ColorValue.warmBlue: Color(0xFF3D60DB),
  ColorValue.darkBlue: Color(0xFF1235B2)
};

TextStyle montserratMedium11 = TextStyle(
  fontFamily: 'Montserrat',
  fontWeight: FontWeight.w500,
  fontSize: 11,
);

TextStyle montserratMedium13 = TextStyle(
  fontFamily: 'Montserrat',
  fontWeight: FontWeight.w500,
  fontSize: 11,
);

TextStyle montserratSemiBold14 = TextStyle(
  fontFamily: 'Montserrat',
  fontWeight: FontWeight.w700,
  fontSize: 14,
);

TextStyle montserratSemiBold16 = TextStyle(
  fontFamily: 'Montserrat',
  fontWeight: FontWeight.w700,
  fontSize: 16,
);

//TODO: Glenn - read https://flutter.dev/docs/cookbook/design/themes
TextStyle pageTitleTextStyle = TextStyle(
    color: Colors.black,
    fontFamily: 'Montserrat',
    fontWeight: FontWeight.w700,
    fontSize: 18);

TextStyle categoryTextStyle = montserratSemiBold16;

TextStyle categoryLinkTextStyle =
    montserratSemiBold14.copyWith(color: AppColors[ColorValue.warmBlue]);

TextStyle storyTitleTextStyle =
    montserratMedium13.copyWith(color: Colors.black);

TextStyle storyCategoryTextStyle =
    montserratMedium11.copyWith(color: Colors.black.withOpacity(0.5));

TextStyle habitatTitleTextStyle =
    montserratSemiBold14.copyWith(color: Colors.white);

TextStyle habitatDescriptionTextStyle =
    montserratSemiBold14.copyWith(color: Colors.white.withOpacity(0.6));
