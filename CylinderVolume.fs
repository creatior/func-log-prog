module CylinderVolume
open System

let circleArea radius = 
    let area = Math.PI * radius * radius
    area

let cylinderVolume radius height =
    let area = circleArea radius
    area * height

let multipleAreaHeight area h = area * h
let cylinderVolumeSuperPos = (circleArea >> multipleAreaHeight)