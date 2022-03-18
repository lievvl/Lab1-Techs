package org.MyScala

import scala.util.chaining._

object ScalaProject {
  def square(x: Double): Double = x * x;

  def pimult(x: Double): Double = 3.14 * x;

  def getCircleArea(x: Double): Double =
    x.pipe(square).pipe(pimult)

  sealed trait Shape
  case class Rectangle(h: Double, w: Double) extends Shape
  case class Circle(r: Double) extends Shape
}