"use strict";

var gulp = require("gulp");
var bower = require("gulp-bower");
var del = require("del");

gulp.task("bower", function () {
    return bower()
        .pipe(gulp.dest("wwwroot/lib"));
});

gulp.task("clean", function (cb) {
    del("./wwwroot/lib", cb);
});
          
gulp.task("default", ["bower"]);