# Internship Live Project - The SpaceBar
## Introduction
During my time at The Tech Academy, I worked with a team on two occasions, both with a different project. The first project entailed developing an interactive Django based site for researching things about space, called the SpaceBar. It used APIs from NASA and other sources, web scraping from sites like Wikipedia, and packages like BeautifulSoup, Pandas, and Selenium. During the two week sprint I worked as a Front End developer, focusing on the website's appearance and interactive features.

Much of the site had already been built, so much of my work involved fixing bugs as well as adding new code to improve the UX experience. The work was tedious at times, but that made it all the more satisfying when I finally pinned down the cause of a bug and squashed it. I also discovered that I worked VERY well with a team that had clear lines of communication, well-defined goals, and individual tasks sectioned off into manageable chunks.

Below are descriptions of stories that I worked on, with some code snippets for the larger ones.

## Cafe Nav Bar Abstraction
I created a template for the site's menu nav bar that could be included within the base for the menu and the cafe pages.

Styles.css
```
.sidenav a {
  color: #818181;
  padding: 0.7em calc(0.7em * 1.2);
  text-decoration: none;
  display: inline-block;
  border: 3px solid transparent;
  position: relative;
  font-size: 1.5em;
  cursor: pointer;
  letter-spacing: 0.07em;
}
.sidenav a .text {
  transform: translate3d(0, 0.7em, 0);
  display: block;
  transition: transform 0.4s cubic-bezier(0.2, 0, 0, 1) 0.4s;
}
.sidenav a:after {
  position: absolute;
  content: '';
  bottom: -3px;
  left: calc(0.7em * 1.2);
  right: calc(0.7em * 1.2);
  height: 3px;
  background: #f26522;
  transition: transform 0.8s cubic-bezier(1, 0, 0.37, 1) 0.2s, right 0.2s cubic-bezier(0.04, 0.48, 0, 1) 0.6s, left 0.4s cubic-bezier(0.04, 0.48, 0, 1) 0.6s;
  transform-origin: left;
}
.sidenav .line {
  position: absolute;
  background: #f26522;
}
.sidenav .line.-right, .sidenav .line.-left {
  width: 3px;
  bottom: -3px;
  top: -3px;
  transform: scale3d(1, 0, 1);
}
.sidenav .line.-top, .sidenav .line.-bottom {
  height: 3px;
  left: -3px;
  right: -3px;
  transform: scale3d(0, 1, 1);
}
.sidenav .line.-right {
  right: -3px;
  transition: transform 0.1s cubic-bezier(1, 0, 0.65, 1.01) 0.23s;
  transform-origin: top;
}
.sidenav .line.-top {
  top: -3px;
  transition: transform 0.08s linear 0.43s;
  transform-origin: left;
}
.sidenav .line.-left {
  left: -3px;
  transition: transform 0.08s linear 0.51s;
  transform-origin: bottom;
}
.sidenav .line.-bottom {
  bottom: -3px;
  transition: transform 0.3s cubic-bezier(1, 0, 0.65, 1.01);
  transform-origin: right;
}
.sidenav a:hover .text, .sidenav a:active .text {
  transform: translate3d(0, 0, 0);
  transition: transform 0.6s cubic-bezier(0.2, 0, 0, 1) 0.4s;
}
.sidenav a:hover:after, .sidenav a:active:after {
  transform: scale3d(0, 1, 1);
  right: -3px;
  left: -3px;
  transform-origin: right;
  transition: transform 0.2s cubic-bezier(1, 0, 0.65, 1.01) 0.17s, right 0.2s cubic-bezier(1, 0, 0.65, 1.01), left 0s 0.3s;
}
.sidenav a:hover .line, .sidenav a:active .line {
  transform: scale3d(1, 1, 1);
}
.sidenav a:hover .line.-right, .sidenav a:active .line.-right {
  transition: transform 0.1s cubic-bezier(1, 0, 0.65, 1.01) 0.2s;
  transform-origin: bottom;
}
.sidenav a:hover .line.-top, .sidenav a:active .line.-top {
  transition: transform 0.08s linear 0.4s;
  transform-origin: right;
}
.sidenav a:hover .line.-left, .sidenav a:active .line.-left {
  transition: transform 0.08s linear 0.48s;
  transform-origin: top;
}
.sidenav a:hover .line.-bottom, .sidenav a:active .line.-bottom {
  transition: transform 0.5s cubic-bezier(0, 0.53, 0.29, 1) 0.56s;
  transform-origin: left;
}
```

sidebar.html
```
<!-- Spacebar Side Navigation Bar -->
<div class="sidenav">
    <br><br><br><br><br><br>
    <a href="{% url 'hours' %}">Hours
        <span class="line -right"></span>
        <span class="line -top"></span>
        <span class="line -left"></span>
        <span class="line -bottom"></span>
    </a>
    <a href="{% url 'menu:index' %}">Menu
        <span class="line -right"></span>
        <span class="line -top"></span>
        <span class="line -left"></span>
        <span class="line -bottom"></span>
    </a>
    <a href="{% url 'menu:create' %}">Create
        <span class="line -right"></span>
        <span class="line -top"></span>
        <span class="line -left"></span>
        <span class="line -bottom"></span>
    </a>
    <a href="/iss">Location
        <span class="line -right"></span>
        <span class="line -top"></span>
        <span class="line -left"></span>
        <span class="line -bottom"></span>
    </a>
    <a href="/#contact">Contact
        <span class="line -right"></span>
        <span class="line -top"></span>
        <span class="line -left"></span>
        <span class="line -bottom"></span>
    </a>
</div>
```

## Centered Logo & Animation
I made the site's logo more visible and centered, in addition to giving it a small animation when moused over. The logo was a small rocket icon tilted at a 45° angle, placed in the center of the top navigation bar and functioned as a "home" button. The animation tilted it to point upright and then fly off the page, with the word 'Home' fading in as it lifted off. The rocket would return to its original position when the mouse was no longer over the logo.

Styles.css
```
/* Makes a circular white background */
#circle {
  width: 64px;
  height: 64px;
  text-align: center;
  position: relative;
  z-index: 1;
  -webkit-border-radius: 32px;
  -moz-border-radius: 32px;
  border-radius: 32px;
  background: #fff;
}
/*configures text inside the circle background, but it's not perfectly lined up with the navbar*/
.hometext {
  text-decoration: none;
  border: 3px solid transparent;
  position: relative;
  cursor: pointer;
  z-index: 2;
  top: 15px;
  color: #fff;
}
/*rocket logo move*/
#navlogo {
  max-width: 64px;
  position: relative;
}
/* animates the logo */
div.rocket {
  position: absolute;
  z-index: 3;
  -webkit-transition: 1s 1s;
  -moz-transition: 1s 1s;
  -o-transition: 1s 1s;
  transition: 1s 1s;
}
div.rocket div {
  background: url(/static/images/rocket1.png) no-repeat;
  -webkit-transition: 1s ease-in-out;
  -moz-transition: 1s ease-in-out;
  -o-transition: 1s ease-in-out;
  transition: 1s ease-in-out;
}
div.hometext {
  -webkit-transition: 1s 1.25s;
  -moz-transition: 1s 1.25s;
  -o-transition: 1s 1.25s;
  transition: 1s 1.25s;
}
/* logo final state */
#circle:hover div.rocket {
  -webkit-transform: translateY(-100px);
  -moz-transform: translateY(-100px);
  -o-transform: translateY(-100px);
  -ms-transform: translateY(-100px);
  transform: translateY(-100px);
}
#circle:hover div.rocket div {
  -webkit-transform: rotate(-45deg);
  -moz-transform: rotate(-45deg);
  -o-transform: rotate(-45deg);
  -ms-transform: rotate(-45deg);
  transform: rotate(-45deg);
}
#circle:hover div.hometext {
  color: #818181;
}
```

## Main Page Easter Eggs
My final task on the project was adding easter eggs to the main page to entertain the users.

The first was a music track that played when a specific part of a particular image (a jukebox) was clicked on. This was particularly difficult since I needed the image map to resize itself dynamically along with the image it was tied to, but I managed to hunt down some code that would do the trick.

home_base.html
```
  <!-- Jukebox Map: Created by Online Image Map Editor (http://www.maschek.hu/imagemap/index) -->
  <map id="jukemap" name="jukemap">
    <area shape="poly" alt="Jukebox" href="#" coords="354,202,421,215,467,251,497,321,525,639,262,679,224,331,252,254,291,219" onClick="music.paused?music.play():music.pause(); return false;" />
    </map>
  
    <!-- Jukebox Audio -->
  <audio id="music">
    <source src="{% static 'audio/BelowTheAsteroids.mp3' %}" type="audio/mp3" hidden="true" loop="true">
  </audio>
```

Base.html
```
<!-- Image Map Resizer courtesy of https://github.com/davidjbradshaw/image-map-resizer -->
    <script type="text/javascript" src="{% static 'js/imageMapResizer.min.js' %}"></script>
    <script type="text/javascript">
      $('map').imageMapResize();
    </script>
```

scripts.js
```
//Easter Egg Audio
var music = document.getElementById("music");
function togglePlay() {
  return music.paused ? music.play() : music.pause();
};
```

imageMapResizer.min.js
```
/*! Image Map Resizer (imageMapResizer.min.js ) - v1.0.10 - 2019-04-10
 *  Desc: Resize HTML imageMap to scaled image.
 *  Copyright: (c) 2019 David J. Bradshaw - dave@bradshaw.net
 *  License: MIT
 */

!(function() {
  "use strict";
  function r() {
    function e() {
      var r = {
          width: u.width / u.naturalWidth,
          height: u.height / u.naturalHeight
        },
        a = {
          width: parseInt(
            window.getComputedStyle(u, null).getPropertyValue("padding-left"),
            10
          ),
          height: parseInt(
            window.getComputedStyle(u, null).getPropertyValue("padding-top"),
            10
          )
        };
      i.forEach(function(e, t) {
        var n = 0;
        o[t].coords = e
          .split(",")
          .map(function(e) {
            var t = 1 == (n = 1 - n) ? "width" : "height";
            return a[t] + Math.floor(Number(e) * r[t]);
          })
          .join(",");
      });
    }
    function t(e) {
      return e.coords.replace(/ *, */g, ",").replace(/ +/g, ",");
    }
    function n() {
      clearTimeout(d), (d = setTimeout(e, 250));
    }
    function r(e) {
      return document.querySelector('img[usemap="' + e + '"]');
    }
    var a = this,
      o = null,
      i = null,
      u = null,
      d = null;
    "function" != typeof a._resize
      ? ((o = a.getElementsByTagName("area")),
        (i = Array.prototype.map.call(o, t)),
        (u = r("#" + a.name) || r(a.name)),
        (a._resize = e),
        u.addEventListener("load", e, !1),
        window.addEventListener("focus", e, !1),
        window.addEventListener("resize", n, !1),
        window.addEventListener("readystatechange", e, !1),
        document.addEventListener("fullscreenchange", e, !1),
        (u.width === u.naturalWidth && u.height === u.naturalHeight) || e())
      : a._resize();
  }
  function e() {
    function t(e) {
      e &&
        (!(function(e) {
          if (!e.tagName)
            throw new TypeError("Object is not a valid DOM element");
          if ("MAP" !== e.tagName.toUpperCase())
            throw new TypeError(
              "Expected <MAP> tag, found <" + e.tagName + ">."
            );
        })(e),
        r.call(e),
        n.push(e));
    }
    var n;
    return function(e) {
      switch (((n = []), typeof e)) {
        case "undefined":
        case "string":
          Array.prototype.forEach.call(
            document.querySelectorAll(e || "map"),
            t
          );
          break;
        case "object":
          t(e);
          break;
        default:
          throw new TypeError("Unexpected data type (" + typeof e + ").");
      }
      return n;
    };
  }
  "function" == typeof define && define.amd
    ? define([], e)
    : "object" == typeof module && "object" == typeof module.exports
    ? (module.exports = e())
    : (window.imageMapResize = e()),
    "jQuery" in window &&
      (window.jQuery.fn.imageMapResize = function() {
        return this.filter("map")
          .each(r)
          .end();
      });
})();
//# sourceMappingURL=imageMapResizer.map
```

The second easter egg was a much simpler "Konami code" sequence that would play a video tribute to everyone who has risked - and in some cases, lost - their lives in the name of exploring space.

konami.js
```
// a key map of allowed keys
var allowedKeys = {
    37: 'left',
    38: 'up',
    39: 'right',
    40: 'down',
    65: 'a',
    66: 'b'
  };
  
  // the 'official' Konami Code sequence
  var konamiCode = ['up', 'up', 'down', 'down', 'left', 'right', 'left', 'right', 'b', 'a'];
  
  // a variable to remember the 'position' the user has reached so far.
  var konamiCodePosition = 0;
  
  // add keydown event listener
  document.addEventListener('keydown', function(e) {
    // get the value of the key code from the key map
    var key = allowedKeys[e.keyCode];
    // get the value of the required key from the konami code
    var requiredKey = konamiCode[konamiCodePosition];
  
    // compare the key with the required key
    if (key == requiredKey) {
  
      // move to the next key in the konami code sequence
      konamiCodePosition++;
  
      // if the last key is reached, activate cheats
      if (konamiCodePosition == konamiCode.length) {
        activateCheats();
        konamiCodePosition = 0;
      }
    } else {
      konamiCodePosition = 0;
    }
  });
  
  function activateCheats() {
    window.open("https://www.youtube.com/watch?v=2NtXXv21_AE");
  }
```

## Minor Work/Bugfixes
* Fixed the background image so that the page's content would scroll over it, instead of the image scrolling with the page.
* Fixed the "Address" card in the "Contact" section so that it would display properly
* Modified the subscription method on the main page from a plain e-mail field to a button with hover effects.
