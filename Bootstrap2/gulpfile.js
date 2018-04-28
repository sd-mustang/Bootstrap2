var gulp = require("gulp"),
    cssmin = require("gulp-cssmin"),
    less = require("gulp-less");

gulp.task("less", function () {
    return gulp.src('Styles/main.less')
        .pipe(less())
        .pipe(gulp.dest('wwwroot/css'));
})

gulp.task("min:css", function () {
    return gulp.src('wwwroot/css/main.css')
        .pipe(cssmin())
        .pipe(gulp.dest('wwwroot/css/minified/main.min.css'));
})