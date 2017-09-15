@import url("https://fonts.googleapis.com/css?family=Titillium+Web:200i,400,400i,700");
@import url("https://fonts.googleapis.com/css?family=Titillium+Web:200i,400,400i,700");
@import url("https://fonts.googleapis.com/css?family=Titillium+Web:200i,400,400i,700");
@import url("https://fonts.googleapis.com/css?family=Titillium+Web:200i,400,400i,700");
@import url("https://fonts.googleapis.com/css?family=Titillium+Web:200i,400,400i,700");
@import url("https://fonts.googleapis.com/css?family=Titillium+Web:200i,400,400i,700");
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: "Titillium Web", sans-serif; }

ul li {
  list-style: none; }

a {
  text-decoration: none; }

section, footer {
  position: relative;
  width: 100%;
  overflow: hidden;
  z-index: 1; }

.header {
  position: relative;
  width: 100%;
  height: 100vh;
  background-image: url("../img/bunner.jpg");
  background-position: center;
  background-repeat: no-repeat;
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  -ms-background-size: cover;
  background-size: cover; }
  .header__overlay {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: -moz-linear-gradient(-45deg, rgba(243, 255, 189, 0.74) 0%, rgba(243, 255, 189, 0.74) 23%, rgba(243, 255, 189, 0.9) 71%, rgba(243, 255, 189, 0.98) 93%, #f3ffbd 99%, rgba(243, 255, 189, 0.6) 100%);
    background: -webkit-linear-gradient(-45deg, rgba(243, 255, 189, 0.74) 0%, rgba(243, 255, 189, 0.74) 23%, rgba(243, 255, 189, 0.9) 71%, rgba(243, 255, 189, 0.98) 93%, #f3ffbd 99%, rgba(243, 255, 189, 0.6) 100%);
    background: linear-gradient(135deg, rgba(243, 255, 189, 0.74) 0%, rgba(243, 255, 189, 0.74) 23%, rgba(243, 255, 189, 0.9) 71%, rgba(243, 255, 189, 0.98) 93%, #f3ffbd 99%, rgba(243, 255, 189, 0.6) 100%);
    filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#bdf3ffbd', endColorstr='#99f3ffbd',GradientType=1 ); }

.main-nav {
  top: 0;
  width: 100%;
  height: 100px;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center;
  -webkit-transition: background 0.3s linear;
  -moz-transition: background 0.3s linear;
  -o-transition: background 0.3s linear;
  -ms-transition: background 0.3s linear;
  transition: background 0.3s linear; }
  .main-nav__logoLinxBox {
    position: relative;
    width: 80%;
    height: 100px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center;
    -webkit-justify-content: space-between;
    -moz-justify-content: space-between;
    -ms-justify-content: space-between;
    justify-content: space-between;
    -ms-flex-pack: space-between; }
    .main-nav__logoLinxBox .linx {
      -webkit-align-items: start;
      -moz-align-items: start;
      -ms-align-items: start;
      align-items: start;
      font-size: 1.5em; }
      .main-nav__logoLinxBox .linx::-webkit-input-placeholder {
        opacity: 1;
        font-size: 20px;
        color: #b2dbbd; }
      .main-nav__logoLinxBox .linx:-moz-placeholder {
        opacity: 1;
        font-size: 20px;
        color: #b2dbbd; }
      .main-nav__logoLinxBox .linx::-moz-placeholder {
        opacity: 1;
        font-size: 20px;
        color: #b2dbbd; }
      .main-nav__logoLinxBox .linx:-ms-input-placeholder {
        opacity: 1;
        font-size: 20px;
        color: #b2dbbd; }
      .main-nav__logoLinxBox .linx:-o-input-placeholder {
        opacity: 1;
        font-size: 20px;
        color: #b2dbbd; }
      .main-nav__logoLinxBox .linx:placeholder {
        opacity: 1;
        font-size: 20px;
        color: #b2dbbd; }
      .main-nav__logoLinxBox .linx__link--sliding-middle-out {
        display: inline-block;
        position: relative;
        padding-bottom: 3px; }
      .main-nav__logoLinxBox .linx__link--sliding-middle-out:after {
        content: '';
        display: block;
        margin: auto;
        height: 3px;
        width: 0px;
        background: transparent;
        transition: width .3s ease, background-color .3s ease; }
      .main-nav__logoLinxBox .linx__link--sliding-middle-out:hover:after {
        width: 100%;
        background: white; }
      .main-nav__logoLinxBox .linx a {
        color: #0F76A2; }
        .main-nav__logoLinxBox .linx a:visited {
          color: none; }
        .main-nav__logoLinxBox .linx a:hover {
          color: #23527c; }
      .main-nav__logoLinxBox .linx a {
        -webkit-transition: color 0.3s ease-in-out;
        -moz-transition: color 0.3s ease-in-out;
        -o-transition: color 0.3s ease-in-out;
        -ms-transition: color 0.3s ease-in-out;
        transition: color 0.3s ease-in-out; }

.hidden {
  visibility: hidden; }

.visible {
  visibility: visible; }

.hiddenInp {
  display: none; }

.show {
  display: block; }

.search-btn {
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center;
  position: relative;
  width: 40px;
  height: 40px;
  cursor: pointer;
  background: #70c1b3;
  -webkit-border-radius: 4px;
  -moz-border-radius: 4px;
  -ms-border-radius: 4px;
  -o-border-radius: 4px;
  border-radius: 4px; }
  .search-btn .search {
    cursor: pointer;
    color: white;
    font-size: 20px;
    -webkit-transition: color 0.3s ease-in-out;
    -moz-transition: color 0.3s ease-in-out;
    -o-transition: color 0.3s ease-in-out;
    -ms-transition: color 0.3s ease-in-out;
    transition: color 0.3s ease-in-out; }
    .search-btn .search:hover {
      color: #23527c; }

.main-nav__logo {
  position: relative;
  width: 100px;
  height: 100px;
  background-image: url("../img/logologo.png");
  background-position: top;
  background-repeat: none;
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  -ms-background-size: cover;
  background-size: cover; }

.form-search {
  position: fixed;
  top: 0;
  width: 100%;
  height: 100vh;
  background: rgba(255, 255, 255, 0.9);
  z-index: 11111;
  display: none;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center; }
  .form-search__input {
    display: none;
    outline: none;
    width: 100%;
    height: 80px;
    border: 0px none;
    padding-left: 90px;
    font-size: 30px;
    background: rgba(0, 0, 0, 0) none repeat scroll right center; }
  .form-search__close {
    display: none;
    width: 40px;
    height: 40px;
    margin-right: 30px;
    cursor: pointer;
    -webkit-border-radius: 4px;
    -moz-border-radius: 4px;
    -ms-border-radius: 4px;
    -o-border-radius: 4px;
    border-radius: 4px;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center;
    background: #70c1b3; }
    .form-search__close .close {
      cursor: pointer;
      color: white;
      font-size: 24px;
      z-index: 10;
      -webkit-transition: color 0.3s ease-in-out;
      -moz-transition: color 0.3s ease-in-out;
      -o-transition: color 0.3s ease-in-out;
      -ms-transition: color 0.3s ease-in-out;
      transition: color 0.3s ease-in-out; }
      .form-search__close .close:hover {
        color: #23527c; }

.active {
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex; }

/*----------Part for setting SLIDER------------*/
.box_slider {
  width: 100%;
  height: 400px;
  margin-top: 60px;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center; }
  .box_slider .slider {
    width: 50%;
    height: 400px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center; }
    .box_slider .slider .slick-list {
      position: relative;
      display: block;
      overflow: hidden;
      margin: 0;
      padding: 0;
      text-align: center; }

.box_slider div h1 {
  font-size: 6em;
  color: #0F76A2; }
.box_slider div h3 {
  font-size: 30px;
  font-weight: 400;
  color: #0F76A2; }

.slick-dotted.slick-slider {
  margin-bottom: 0px; }

.slick-initialized .slick-slide {
  width: 720px;
  text-align: center;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-flex-direction: column;
  -moz-flex-direction: column;
  -ms-flex-direction: column;
  flex-direction: column;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center; }

.slick-list {
  position: relative;
  display: block;
  overflow: hidden;
  margin: 0;
  padding: 0;
  text-align: center; }

.slick-dots {
  position: absolute;
  bottom: -25px;
  display: block;
  width: 100%;
  height: 50px;
  padding: 0;
  margin: 0;
  margin-top: 50px;
  list-style: none;
  text-align: center;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center; }
  .slick-dots li {
    position: relative;
    display: inline-block;
    width: 50px;
    height: 50px;
    margin: 0 10px;
    padding: 0;
    cursor: pointer; }
    .slick-dots li.slick-active button::before {
      opacity: 1;
      color: black; }
    .slick-dots li button {
      font-size: 0;
      line-height: 0;
      display: block;
      width: 50px;
      height: 50px;
      padding: 5px;
      -webkit-border-radius: 50px;
      -moz-border-radius: 50px;
      -ms-border-radius: 50px;
      -o-border-radius: 50px;
      border-radius: 50px;
      cursor: pointer;
      color: transparent;
      border: 0;
      outline: none;
      background: rgba(0, 0, 0, 0.4);
      -webkit-transition: background 0.3s ease;
      -moz-transition: background 0.3s ease;
      -o-transition: background 0.3s ease;
      -ms-transition: background 0.3s ease;
      transition: background 0.3s ease; }
      .slick-dots li button:hover {
        background: white; }

.slick-dots li button::before {
  line-height: 20px;
  position: absolute;
  top: 0;
  left: 0;
  width: 50px;
  height: 50px;
  content: "";
  text-align: center;
  opacity: .77;
  color: black;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  -webkit-border-radius: 50px;
  -moz-border-radius: 50px;
  -ms-border-radius: 50px;
  -o-border-radius: 50px;
  border-radius: 50px; }

.slick-dots li:nth-child(-n+6) button:before {
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  -ms-background-size: cover;
  background-size: cover; }
.slick-dots li:nth-child(1) button:before {
  background-image: url("../img/HTML5-logo.jpg");
  background-position: center;
  background-repeat: no-repeat; }
.slick-dots li:nth-child(2) button:before {
  background-image: url("../img/css-logo.jpg");
  background-position: center;
  background-repeat: no-repeat; }
.slick-dots li:nth-child(3) button:before {
  background-image: url("../img/javascript-logo.jpg");
  background-position: center;
  background-repeat: no-repeat; }
.slick-dots li:nth-child(4) button:before {
  background-image: url("../img/php-logo.jpg");
  background-position: center;
  background-repeat: no-repeat; }
.slick-dots li:nth-child(5) button:before {
  background-image: url("../img/mysql-logo.jpg");
  background-position: center;
  background-repeat: no-repeat; }
.slick-dots li:nth-child(6) button:before {
  background-image: url("../img/fw-logo.jpg");
  background-position: center;
  background-repeat: no-repeat; }

.discription {
  width: 100%;
  height: 500px;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex; }

.dwrap {
  width: 100%;
  background: #efefef;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center; }
  .dwrap__boxText {
    width: 80%;
    height: 350px;
    margin-top: 40px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center; }
    .dwrap__boxText h3 {
      font-size: 30px;
      margin-bottom: 20px; }
      .dwrap__boxText h3 span {
        color: #8c8c8c;
        font-weight: 200; }
    .dwrap__boxText p {
      color: #8c8c8c;
      line-height: 150%;
      font-size: 18px; }
      .dwrap__boxText p span {
        font-style: italic; }

.dwrap--myName {
  margin-top: 20px;
  font-style: italic;
  font-weight: 400; }
  .dwrap--myName span {
    color: #70c1b3; }

.dboxImg {
  position: relative;
  width: 100%;
  height: 500px;
  overflow: hidden; }
  .dboxImg__table_img {
    position: relative;
    width: 100%;
    height: 100%; }
  .dboxImg__overlay {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.07);
    z-index: 1; }

.features {
  width: 100%;
  height: 500px;
  margin-bottom: 40px;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center;
  -webkit-flex-direction: column;
  -moz-flex-direction: column;
  -ms-flex-direction: column;
  flex-direction: column;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center; }
  .features h3 {
    font-size: 30px;
    margin-top: 40px; }
    .features h3 span {
      color: #8c8c8c;
      font-weight: 200; }

.fFullBox {
  width: 80%;
  height: 500px;
  margin-top: 40px;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center;
  -webkit-flex-direction: column;
  -moz-flex-direction: column;
  -ms-flex-direction: column;
  flex-direction: column; }
  .fFullBox__box {
    width: 100%;
    margin-bottom: 40px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: row;
    -moz-flex-direction: row;
    -ms-flex-direction: row;
    flex-direction: row; }

.fFullBox__part {
  width: 40%;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex; }
.fFullBox__icon {
  position: relative;
  width: 60px;
  height: 60px;
  margin-right: 15px; }
  .fFullBox__icon i {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    color: #b2dbbd;
    font-size: 3.5em; }
.fFullBox__discrb {
  width: 80%; }
  .fFullBox__discrb h4 {
    margin-bottom: 10px;
    font-size: 20px;
    font-weight: bold; }
  .fFullBox__discrb p {
    font-size: 15px;
    color: #8c8c8c; }

.tuts {
  position: relative;
  width: 100%;
  height: 550px;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-flex-direction: column;
  -moz-flex-direction: column;
  -ms-flex-direction: column;
  flex-direction: column;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center;
  background: #70c1b3;
  z-index: 1; }
  .tuts h3 {
    text-align: center;
    font-size: 30px;
    margin-top: 40px; }
    .tuts h3 span {
      color: #fff;
      font-weight: 200; }

.tuts-wrap {
  width: 100%;
  height: 500px;
  padding-bottom: 40px;
  display: flex;
  justify-content: center;
  align-items: center; }
  .tuts-wrap__tutsBox {
    width: 80%;
    height: 400px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: row;
    -moz-flex-direction: row;
    -ms-flex-direction: row;
    flex-direction: row;
    -webkit-justify-content: space-between;
    -moz-justify-content: space-between;
    -ms-justify-content: space-between;
    justify-content: space-between;
    -ms-flex-pack: space-between;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center; }

.tuts-wrap__tuto {
  position: relative;
  overflow: hidden;
  width: 30%;
  height: 290px;
  -webkit-border-radius: 3%;
  -moz-border-radius: 3%;
  -ms-border-radius: 3%;
  -o-border-radius: 3%;
  border-radius: 3%;
  -webkit-background-size: cover;
  -moz-background-size: cover;
  -o-background-size: cover;
  -ms-background-size: cover;
  background-size: cover; }
  .tuts-wrap__tuto img {
    position: relative;
    width: 100%;
    height: 230px;
    overflow: hidden;
    -webkit-transition: transform 0.5s linear;
    -moz-transition: transform 0.5s linear;
    -o-transition: transform 0.5s linear;
    -ms-transition: transform 0.5s linear;
    transition: transform 0.5s linear; }
  .tuts-wrap__tuto:hover img {
    -webkit-transform: scale3d(1.2, 1.2, 1);
    -moz-transform: scale3d(1.2, 1.2, 1);
    -ms-transform: scale3d(1.2, 1.2, 1);
    -o-transform: scale3d(1.2, 1.2, 1);
    transform: scale3d(1.2, 1.2, 1); }
  .tuts-wrap__tuto:hover .tuts-wrap__maskTuto {
    background: #f3ffbd;
    /* The Fallback */
    background: rgba(243, 255, 189, 0.8);
    -webkit-transition: background 0.3s ease-in-out;
    -moz-transition: background 0.3s ease-in-out;
    -o-transition: background 0.3s ease-in-out;
    -ms-transition: background 0.3s ease-in-out;
    transition: background 0.3s ease-in-out;
    visibility: visible; }
  .tuts-wrap__tuto:hover .figure__link {
    visibility: visible;
    -webkit-transition: visibility 0.6s linear;
    -moz-transition: visibility 0.6s linear;
    -o-transition: visibility 0.6s linear;
    -ms-transition: visibility 0.6s linear;
    transition: visibility 0.6s linear; }

.figure__link {
  position: absolute;
  top: 30%;
  left: 30%;
  z-index: 3;
  visibility: hidden;
  cursor: pointer;
  pointer-events: auto;
  border: 3px solid black;
  padding: 7px; }
  .figure__link span {
    color: black;
    font-weight: 400;
    text-transform: uppercase; }

.tuts-wrap__maskTuto {
  position: absolute;
  width: 100%;
  height: 100%;
  top: 0;
  left: 0;
  visibility: hidden; }

.tuts-wrap__text {
  background: #eee;
  position: absolute;
  bottom: 0;
  z-index: 1;
  padding: 15px; }
  .tuts-wrap__text p {
    font-size: 15px; }

.aboutUs {
  height: 600px;
  padding: 0 15px;
  margin: 40px 0; }
  .aboutUs h3 {
    text-align: center;
    margin-bottom: 20px; }

.about {
  width: 80%;
  margin: 0 auto;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: space-evenly;
  -moz-justify-content: space-evenly;
  -ms-justify-content: space-evenly;
  justify-content: space-evenly;
  -ms-flex-pack: space-evenly;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center; }
  .about__card {
    position: relative;
    width: 30%;
    height: 400px;
    overflow: hidden; }
    .about__card__mask {
      position: absolute;
      width: 100%;
      height: 100%;
      top: 0;
      right: 0;
      background: rgba(0, 0, 0, 0.5);
      z-index: 2; }
    .about__card img {
      position: absolute;
      width: 100%;
      height: 100%; }
    .about__card__desc {
      position: absolute;
      bottom: 0;
      width: 100%;
      height: 100px;
      background: #ccc;
      z-index: 3; }
      .about__card__desc h5 {
        color: white; }

.contact {
  position: relative;
  width: 100%;
  height: 500px;
  background: #f3ffbd;
  overflow: hidden;
  z-index: 1;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-flex-direction: column;
  -moz-flex-direction: column;
  -ms-flex-direction: column;
  flex-direction: column;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center; }
  .contact h3 {
    font-size: 30px;
    margin-top: 40px; }
    .contact h3 span {
      font-weight: 400;
      color: #8c8c8c; }

.contWrap__btn {
  font-size: 0.875em;
  width: 470px;
  height: 50px;
  padding: 0px 15px 0px 15px;
  background: transparent;
  cursor: pointer;
  outline: none;
  color: #726659;
  border: solid 1px #70c1b3;
  border-top: none;
  -webkit-transition: all 0.3s ease-in-out;
  -moz-transition: all 0.3s ease-in-out;
  -o-transition: all 0.3s ease-in-out;
  -ms-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out; }
  .contWrap__btn:hover, .contWrap__btn:focus {
    background: #70c1b3;
    color: white; }

.contWrap {
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  width: 80%;
  height: 500px;
  -webkit-justify-content: space-around;
  -moz-justify-content: space-around;
  -ms-justify-content: space-around;
  justify-content: space-around;
  -ms-flex-pack: space-around;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center; }
  .contWrap__box {
    width: 40%;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center; }
  .contWrap__input {
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column; }
    .contWrap__input input {
      font-size: 0.875em;
      width: 470px;
      height: 50px;
      padding: 0px 15px 0px 15px;
      background: transparent;
      color: white;
      outline: none;
      color: #726659;
      border: solid 1px #70c1b3;
      border-bottom: none;
      -webkit-transition: all 0.3s ease-in-out;
      -moz-transition: all 0.3s ease-in-out;
      -o-transition: all 0.3s ease-in-out;
      -ms-transition: all 0.3s ease-in-out;
      transition: all 0.3s ease-in-out; }
      .contWrap__input input:hover, .contWrap__input input:focus, .contWrap__input input:active {
        background: #70c1b3; }
        .contWrap__input input:hover::-webkit-input-placeholder, .contWrap__input input:focus::-webkit-input-placeholder, .contWrap__input input:active::-webkit-input-placeholder {
          color: white;
          opacity: 1;
          -webkit-transform: translateX(50px);
          -moz-transform: translateX(50px);
          -ms-transform: translateX(50px);
          -o-transform: translateX(50px);
          transform: translateX(50px); }
        .contWrap__input input:hover:-moz-placeholder, .contWrap__input input:focus:-moz-placeholder, .contWrap__input input:active:-moz-placeholder {
          color: white;
          opacity: 1;
          -webkit-transform: translateX(50px);
          -moz-transform: translateX(50px);
          -ms-transform: translateX(50px);
          -o-transform: translateX(50px);
          transform: translateX(50px); }
        .contWrap__input input:hover::-moz-placeholder, .contWrap__input input:focus::-moz-placeholder, .contWrap__input input:active::-moz-placeholder {
          color: white;
          opacity: 1;
          -webkit-transform: translateX(50px);
          -moz-transform: translateX(50px);
          -ms-transform: translateX(50px);
          -o-transform: translateX(50px);
          transform: translateX(50px); }
        .contWrap__input input:hover:-ms-input-placeholder, .contWrap__input input:focus:-ms-input-placeholder, .contWrap__input input:active:-ms-input-placeholder {
          color: white;
          opacity: 1;
          -webkit-transform: translateX(50px);
          -moz-transform: translateX(50px);
          -ms-transform: translateX(50px);
          -o-transform: translateX(50px);
          transform: translateX(50px); }
        .contWrap__input input:hover:-o-input-placeholder, .contWrap__input input:focus:-o-input-placeholder, .contWrap__input input:active:-o-input-placeholder {
          color: white;
          opacity: 1;
          -webkit-transform: translateX(50px);
          -moz-transform: translateX(50px);
          -ms-transform: translateX(50px);
          -o-transform: translateX(50px);
          transform: translateX(50px); }
        .contWrap__input input:hover:placeholder, .contWrap__input input:focus:placeholder, .contWrap__input input:active:placeholder {
          color: white;
          opacity: 1;
          -webkit-transform: translateX(50px);
          -moz-transform: translateX(50px);
          -ms-transform: translateX(50px);
          -o-transform: translateX(50px);
          transform: translateX(50px); }

.contWrap__mess {
  width: 470px;
  max-width: 470px;
  height: 110px;
  max-height: 110px;
  padding: 15px;
  background: transparent;
  color: white;
  outline: none;
  color: #726659;
  font-size: 0.875em;
  border: solid 1px #70c1b3;
  -webkit-transition: all 0.3s ease-in-out;
  -moz-transition: all 0.3s ease-in-out;
  -o-transition: all 0.3s ease-in-out;
  -ms-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out; }
  .contWrap__mess:hover, .contWrap__mess:focus {
    background: #70c1b3; }
    .contWrap__mess:hover::-webkit-input-placeholder, .contWrap__mess:focus::-webkit-input-placeholder {
      color: white;
      opacity: 1; }
    .contWrap__mess:hover:-moz-placeholder, .contWrap__mess:focus:-moz-placeholder {
      color: white;
      opacity: 1; }
    .contWrap__mess:hover::-moz-placeholder, .contWrap__mess:focus::-moz-placeholder {
      color: white;
      opacity: 1; }
    .contWrap__mess:hover:-ms-input-placeholder, .contWrap__mess:focus:-ms-input-placeholder {
      color: white;
      opacity: 1; }
    .contWrap__mess:hover:-o-input-placeholder, .contWrap__mess:focus:-o-input-placeholder {
      color: white;
      opacity: 1; }
    .contWrap__mess:hover:placeholder, .contWrap__mess:focus:placeholder {
      color: white;
      opacity: 1; }

.contWrap__iconBox {
  width: 40%;
  height: 100px;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center; }
.contWrap__icon {
  -webkit-transition: all 0.3s ease-in-out;
  -moz-transition: all 0.3s ease-in-out;
  -o-transition: all 0.3s ease-in-out;
  -ms-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out;
  font-size: 2.5em;
  color: black; }
.contWrap__text {
  font-size: 20px;
  color: #8c8c8c; }

.contWrap__link {
  width: 70px;
  height: 70px;
  -webkit-border-radius: 50px;
  -moz-border-radius: 50px;
  -ms-border-radius: 50px;
  -o-border-radius: 50px;
  border-radius: 50px;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center;
  -webkit-transition: all 0.3s ease-in-out;
  -moz-transition: all 0.3s ease-in-out;
  -o-transition: all 0.3s ease-in-out;
  -ms-transition: all 0.3s ease-in-out;
  transition: all 0.3s ease-in-out; }
  .contWrap__link:hover {
    background: black; }
    .contWrap__link:hover .contWrap__icon {
      color: white; }

.footer {
  height: 300px;
  background: #042c3c;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-flex-direction: column;
  -moz-flex-direction: column;
  -ms-flex-direction: column;
  flex-direction: column;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center; }
  .footer__wrap {
    width: 100%;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center; }
  .footer__box {
    width: 80%;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center; }
  .footer__imgBox {
    position: relative;
    width: 100px;
    height: 70px;
    overflow: hidden; }
    .footer__imgBox img {
      max-width: 100%; }

.footer__part {
  width: 30%;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-flex-direction: column;
  -moz-flex-direction: column;
  -ms-flex-direction: column;
  flex-direction: column;
  -webkit-justify-content: besline;
  -moz-justify-content: besline;
  -ms-justify-content: besline;
  justify-content: besline;
  -ms-flex-pack: besline;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center; }
  .footer__part h4 {
    color: whitesmoke;
    font-size: 20px;
    margin-bottom: 20px; }
  .footer__part p {
    color: whitesmoke;
    font-size: 20px; }
  .footer__part--fst {
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center;
    margin-top: 0; }
    .footer__part--fst p {
      font-size: 15px; }

.fList {
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-flex-direction: column;
  -moz-flex-direction: column;
  -ms-flex-direction: column;
  flex-direction: column;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center;
  margin-top: 10px; }
  .fList--snd {
    width: 100%;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: row;
    -moz-flex-direction: row;
    -ms-flex-direction: row;
    flex-direction: row;
    -webkit-justify-content: space-evenly;
    -moz-justify-content: space-evenly;
    -ms-justify-content: space-evenly;
    justify-content: space-evenly;
    -ms-flex-pack: space-evenly;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center; }
  .fList__item {
    font-size: 15px;
    margin-bottom: 5px; }
    .fList__item:nth-child(3) {
      margin-bottom: 0; }
  .fList--3th {
    width: 50%;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: row;
    -moz-flex-direction: row;
    -ms-flex-direction: row;
    flex-direction: row;
    -webkit-justify-content: space-around;
    -moz-justify-content: space-around;
    -ms-justify-content: space-around;
    justify-content: space-around;
    -ms-flex-pack: space-around;
    -webkit-align-items: baseline;
    -moz-align-items: baseline;
    -ms-align-items: baseline;
    align-items: baseline; }
    .fList--3th li a i {
      font-size: 30px; }
  .fList__link {
    color: whitesmoke;
    -webkit-transition: color 0.3s ease-in-out;
    -moz-transition: color 0.3s ease-in-out;
    -o-transition: color 0.3s ease-in-out;
    -ms-transition: color 0.3s ease-in-out;
    transition: color 0.3s ease-in-out; }
    .fList__link:hover, .fList__link:focus {
      color: #b2dbbd; }
    .fList__link:hover i, .fList__link:focus i {
      -webkit-transition: color 0.3s ease-in-out;
      -moz-transition: color 0.3s ease-in-out;
      -o-transition: color 0.3s ease-in-out;
      -ms-transition: color 0.3s ease-in-out;
      transition: color 0.3s ease-in-out;
      color: #b2dbbd; }
  .fList h4 {
    color: whitesmoke; }
  .fList p {
    font-size: 15px; }

.copyright {
  position: relative;
  bottom: 0;
  width: 100%;
  padding: 20px;
  background: #132127;
  display: -webkit-box;
  display: -moz-box;
  display: -ms-flexbox;
  display: -webkit-flex;
  display: flex;
  -webkit-justify-content: center;
  -moz-justify-content: center;
  -ms-justify-content: center;
  justify-content: center;
  -ms-flex-pack: center;
  -webkit-align-items: center;
  -moz-align-items: center;
  -ms-align-items: center;
  align-items: center; }
  .copyright__text {
    font-size: 18px;
    font-weight: 300;
    color: whitesmoke; }
    .copyright__text span {
      font-style: italic; }

@media all and (max-width: 320px) {
  .header {
    height: 600px;
    padding: 0; }

  .main-nav {
    width: 100%;
    height: 60px;
    padding: 0 15px;
    top: 0;
    left: 0;
    z-index: 100;
    -webkit-transition: background 0.3s ease-in-out;
    -moz-transition: background 0.3s ease-in-out;
    -o-transition: background 0.3s ease-in-out;
    -ms-transition: background 0.3s ease-in-out;
    transition: background 0.3s ease-in-out; }
    .main-nav__logoLinxBox {
      width: 100%;
      height: 60px; }
    .main-nav__logo {
      position: relative;
      width: 60px;
      height: 50px;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-align-items: center;
      -moz-align-items: center;
      -ms-align-items: center;
      align-items: center; }
    .main-nav__icon-menu {
      position: relative;
      right: 0%;
      width: 40px;
      height: 40px;
      background: #f3ffbd;
      -webkit-transition: right 0.3s linear;
      -moz-transition: right 0.3s linear;
      -o-transition: right 0.3s linear;
      -ms-transition: right 0.3s linear;
      transition: right 0.3s linear;
      -webkit-border-radius: 4px;
      -moz-border-radius: 4px;
      -ms-border-radius: 4px;
      -o-border-radius: 4px;
      border-radius: 4px; }
    .main-nav__hamburger {
      background-image: url("../img/menu.svg");
      background-position: center;
      background-repeat: no-repeat;
      width: 40px;
      height: 40px;
      cursor: pointer; }
    .main-nav__close {
      background-image: url("../img/close.svg");
      background-position: center;
      background-repeat: no-repeat;
      display: none;
      width: 40px;
      height: 40px;
      cursor: pointer;
      position: absolute;
      right: 0;
      top: 0; }

  .animateIcon {
    right: 18%;
    -webkit-transition: right 0.3s linear;
    -moz-transition: right 0.3s linear;
    -o-transition: right 0.3s linear;
    -ms-transition: right 0.3s linear;
    transition: right 0.3s linear; }

  .bgdNav {
    background: rgba(0, 0, 0, 0.6); }

  .linx {
    width: 100%;
    height: 100vh;
    background: white;
    padding: 20px 0 0 0;
    position: fixed;
    top: 60px;
    left: 0;
    z-index: 100;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column;
    -webkit-justify-content: stretch;
    -moz-justify-content: stretch;
    -ms-justify-content: stretch;
    justify-content: stretch;
    -ms-flex-pack: stretch;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center;
    -webkit-transition: all 0.3s ease-in-out;
    -moz-transition: all 0.3s ease-in-out;
    -o-transition: all 0.3s ease-in-out;
    -ms-transition: all 0.3s ease-in-out;
    transition: all 0.3s ease-in-out;
    -webkit-transform: translate(100%, 0);
    -moz-transform: translate(100%, 0);
    -ms-transform: translate(100%, 0);
    -o-transform: translate(100%, 0);
    transform: translate(100%, 0); }
    .linx__item {
      width: 100%;
      margin-bottom: 10px;
      font-size: 18px;
      padding: 10px 0 10px 20px; }
      .linx__item--current {
        background: #f3ffbd; }
    .linx__link {
      width: 100%; }

  .search-btn {
    position: absolute;
    width: 40px;
    top: -50px;
    right: 6%;
    z-index: 999;
    display: none;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center; }

  .form-search {
    width: 100%;
    height: 60px; }
    .form-search__input {
      padding: 20px;
      width: 80%;
      font-size: 18px; }
    .form-search__close {
      margin-right: 0; }

  .box_slider {
    margin-top: 0; }

  .box_slider .slider {
    width: 100%;
    height: 400px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center; }
    .box_slider .slider div h1 {
      font-size: 2.3em; }
    .box_slider .slider div h3 {
      font-size: 18px;
      padding: 0 15px; }

  .slick-dots li {
    position: relative;
    display: inline-block;
    width: 30px;
    height: 30px;
    margin: 0 5px;
    padding: 0;
    cursor: pointer; }
    .slick-dots li button {
      font-size: 0;
      line-height: 0;
      display: block;
      width: 30px;
      height: 30px;
      padding: 5px; }
      .slick-dots li button:before {
        line-height: 30px;
        position: absolute;
        top: 0;
        left: 0;
        width: 30px;
        height: 30px;
        content: "";
        text-align: center;
        opacity: .77;
        color: black; }

  .discription {
    width: 100%;
    height: auto;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column; }

  .dwrap__boxText {
    width: 100%;
    height: auto;
    padding: 0 15px;
    padding-bottom: 40px; }
    .dwrap__boxText h3 {
      font-size: 20px;
      margin-bottom: 20px; }
    .dwrap__boxText p {
      font-size: 14px;
      margin-top: 20px; }

  .dboxImg {
    position: relative;
    width: 100%;
    height: auto;
    overflow: hidden; }

  .features {
    width: 100%;
    height: auto;
    padding: 0 15px; }
    .features h3 {
      font-size: 20px;
      margin: 20px 0 40px 0; }

  .fFullBox {
    width: 100%;
    height: auto;
    margin: 0; }
    .fFullBox__box {
      width: 100%;
      height: auto;
      margin: 0;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-flex-direction: column;
      -moz-flex-direction: column;
      -ms-flex-direction: column;
      flex-direction: column; }
    .fFullBox__icon {
      position: relative;
      width: 30px;
      height: 30px;
      margin-right: 15px; }
      .fFullBox__icon i {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        color: #b2dbbd;
        font-size: 2em; }
    .fFullBox__discrb {
      width: 100%; }
      .fFullBox__discrb h4 {
        margin-bottom: 10px;
        font-size: 16px;
        font-weight: bold; }
      .fFullBox__discrb p {
        font-size: 14px; }
    .fFullBox__part {
      width: 100%;
      margin-bottom: 20px; }
      .fFullBox__part:nth-child(6) {
        margin-bottom: 0; }

  .tuts {
    position: relative;
    width: 100%;
    height: auto;
    padding: 0 15px; }
    .tuts h3 {
      font-size: 20px;
      margin: 20px 0 40px 0; }

  .tuts-wrap {
    width: 100%;
    height: auto; }
    .tuts-wrap__tutsBox {
      width: 100%;
      height: auto;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-flex-direction: column;
      -moz-flex-direction: column;
      -ms-flex-direction: column;
      flex-direction: column; }
    .tuts-wrap__tuto {
      position: relative;
      overflow: hidden;
      width: 100%;
      height: 290px;
      margin: 20px 0; }
      .tuts-wrap__tuto p {
        font-size: 12px; }

  .figure__link span {
    color: black;
    font-weight: 400;
    text-transform: uppercase;
    font-size: 13px; }

  .contact {
    position: relative;
    width: 100%;
    height: auto;
    padding: 0 15px;
    padding-bottom: 40px; }
    .contact h3 {
      font-size: 20px; }

  .contWrap {
    width: 100%;
    height: auto;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column; }
    .contWrap__box {
      width: 100%;
      margin: 20px 0; }
    .contWrap__iconBox {
      width: 100%;
      height: 100px; }
    .contWrap__link {
      width: 40px;
      height: 40px; }
    .contWrap__icon {
      font-size: 1.5em; }
    .contWrap__text {
      font-size: 14px; }
    .contWrap__boxForm {
      width: 100%; }
    .contWrap__form {
      width: 100%; }
    .contWrap__input {
      width: 100%; }
      .contWrap__input input {
        width: 100%;
        font-size: .8em; }
    .contWrap__mess {
      width: 100%;
      font-size: .8em; }
    .contWrap__button {
      width: 100%; }
    .contWrap__btn {
      width: 100%;
      font-size: .8em; }

  .footer {
    height: auto;
    padding: 0 15px; }
    .footer__wrap {
      width: 100%; }
    .footer__box {
      width: 100%;
      height: 800px;
      -webkit-flex-direction: column;
      -moz-flex-direction: column;
      -ms-flex-direction: column;
      flex-direction: column;
      -webkit-justify-content: space-evenly;
      -moz-justify-content: space-evenly;
      -ms-justify-content: space-evenly;
      justify-content: space-evenly;
      -ms-flex-pack: space-evenly;
      -webkit-align-items: center;
      -moz-align-items: center;
      -ms-align-items: center;
      align-items: center; }
    .footer__part {
      width: 100%;
      margin-bottom: 20px; }
      .footer__part:nth-child(4) {
        margin-bottom: 0; }
      .footer__part h4 {
        font-size: 16px;
        margin-bottom: 20px; }
      .footer__part li a {
        font-size: 14px; }

  .footer__part .fList--snd {
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column; }
  .footer__part .fList--3th {
    width: 80%; }
    .footer__part .fList--3th li a i {
      font-size: 1.7em; }

  .copyright {
    position: relative;
    width: 100%;
    padding: 20px; }
    .copyright p {
      font-size: 16px; } }
/*End of media max-width(320px);*/
/*For small screen also*/
@media all and (min-width: 321px) and (max-width: 420px) {
  .tuts-wrap__tuto {
    width: 80%; } }
@media all and (min-width: 421px) and (max-width: 512px) {
  .tuts-wrap__tuto {
    width: 70%; } }
@media all and (min-width: 512px) and (max-width: 567px) {
  .tuts-wrap__tuto {
    width: 70%; } }
@media all and (min-width: 567px) and (max-width: 768px) {
  .tuts-wrap__tuto {
    width: 50%; } }
@media all and (min-width: 321px) and (max-width: 768px) {
  .header {
    height: 600px;
    padding: 0; }

  .main-nav {
    width: 100%;
    height: 60px;
    padding: 0 15px;
    top: 0;
    left: 0;
    z-index: 100;
    -webkit-transition: background 0.3s ease-in-out;
    -moz-transition: background 0.3s ease-in-out;
    -o-transition: background 0.3s ease-in-out;
    -ms-transition: background 0.3s ease-in-out;
    transition: background 0.3s ease-in-out; }
    .main-nav__logoLinxBox {
      width: 100%;
      height: 60px; }
    .main-nav__logo {
      position: relative;
      width: 60px;
      height: 50px; }
    .main-nav__icon-menu {
      position: relative;
      right: 0%;
      width: 40px;
      height: 40px;
      background: #f3ffbd;
      -webkit-transition: right 0.3s linear;
      -moz-transition: right 0.3s linear;
      -o-transition: right 0.3s linear;
      -ms-transition: right 0.3s linear;
      transition: right 0.3s linear;
      -webkit-border-radius: 4px;
      -moz-border-radius: 4px;
      -ms-border-radius: 4px;
      -o-border-radius: 4px;
      border-radius: 4px; }
    .main-nav__hamburger {
      background-image: url("../img/menu.svg");
      background-position: center;
      background-repeat: no-repeat;
      width: 40px;
      height: 40px;
      cursor: pointer; }
    .main-nav__close {
      background-image: url("../img/close.svg");
      background-position: center;
      background-repeat: no-repeat;
      display: none;
      width: 40px;
      height: 40px;
      cursor: pointer;
      position: absolute;
      right: 0;
      top: 0; }

  .animateIcon {
    right: 12%;
    -webkit-transition: right 0.3s linear;
    -moz-transition: right 0.3s linear;
    -o-transition: right 0.3s linear;
    -ms-transition: right 0.3s linear;
    transition: right 0.3s linear; }

  .bgdNav {
    background: rgba(0, 0, 0, 0.6); }

  .linx {
    width: 100%;
    height: 100vh;
    background: white;
    padding: 20px 0 0 0;
    position: fixed;
    top: 60px;
    left: 0;
    z-index: 100;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column;
    -webkit-justify-content: stretch;
    -moz-justify-content: stretch;
    -ms-justify-content: stretch;
    justify-content: stretch;
    -ms-flex-pack: stretch;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center;
    -webkit-transition: all 0.3s ease-in-out;
    -moz-transition: all 0.3s ease-in-out;
    -o-transition: all 0.3s ease-in-out;
    -ms-transition: all 0.3s ease-in-out;
    transition: all 0.3s ease-in-out;
    -webkit-transform: translate(100%, 0);
    -moz-transform: translate(100%, 0);
    -ms-transform: translate(100%, 0);
    -o-transform: translate(100%, 0);
    transform: translate(100%, 0); }
    .linx__item {
      width: 100%;
      margin-bottom: 10px;
      font-size: 18px;
      padding: 10px 0 10px 20px; }
      .linx__item--current {
        background: #f3ffbd; }
    .linx__link {
      width: 100%; }
    .linx .search-btn {
      position: absolute;
      width: 40px;
      height: 40px;
      top: -50px;
      right: 3%;
      display: none; }

  .form-search {
    width: 100%;
    height: 60px;
    -webkit-justify-content: space-around;
    -moz-justify-content: space-around;
    -ms-justify-content: space-around;
    justify-content: space-around;
    -ms-flex-pack: space-around; }
    .form-search__input {
      padding: 20px;
      width: 80%;
      font-size: 18px; }
    .form-search__close {
      margin-right: 0; }

  .box_slider {
    margin-top: 0; }

  .box_slider .slider {
    width: 100%;
    height: 400px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center; }
    .box_slider .slider div h1 {
      font-size: 3em; }
    .box_slider .slider div h3 {
      font-size: 20px;
      padding: 0 15px; }

  .slick-dots li {
    position: relative;
    display: inline-block;
    width: 35px;
    height: 35px;
    margin: 0 5px;
    padding: 0;
    cursor: pointer; }
    .slick-dots li button {
      font-size: 0;
      line-height: 0;
      display: block;
      width: 35px;
      height: 35px;
      padding: 5px; }
      .slick-dots li button:before {
        line-height: 35px;
        position: absolute;
        top: 0;
        left: 0;
        width: 35px;
        height: 35px;
        content: "";
        text-align: center;
        opacity: .77;
        color: black; }

  .discription {
    width: 100%;
    height: auto;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column; }

  .dwrap__boxText {
    width: 100%;
    margin: 20px 0;
    padding: 0 15px; }
    .dwrap__boxText h3 {
      font-size: 17px; }
    .dwrap__boxText p {
      font-size: 15px; }

  .dboxImg {
    position: relative;
    width: 100%;
    height: auto;
    overflow: hidden; }

  .features {
    width: 100%;
    height: auto;
    padding: 0 15px; }
    .features h3 {
      font-size: 20px;
      margin: 20px 0 40px 0; }

  .fFullBox {
    width: 100%;
    height: auto;
    margin: 0; }
    .fFullBox__box {
      width: 100%;
      height: auto;
      margin: 0;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-flex-direction: column;
      -moz-flex-direction: column;
      -ms-flex-direction: column;
      flex-direction: column; }
    .fFullBox__icon {
      position: relative;
      width: 30px;
      height: 30px;
      margin-right: 25px; }
      .fFullBox__icon i {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        color: #b2dbbd;
        font-size: 2.2em; }
    .fFullBox__discrb {
      width: 100%; }
      .fFullBox__discrb h4 {
        margin-bottom: 10px;
        font-size: 17px;
        font-weight: bold; }
      .fFullBox__discrb p {
        font-size: 15px; }
    .fFullBox__part {
      width: 100%;
      margin-bottom: 20px; }
      .fFullBox__part:nth-child(6) {
        margin-bottom: 0; }

  .tuts {
    position: relative;
    width: 100%;
    height: auto;
    padding: 0 15px; }
    .tuts h3 {
      font-size: 20px;
      margin: 20px 0 40px 0; }

  .tuts-wrap {
    width: 100%;
    height: auto; }
    .tuts-wrap__tutsBox {
      width: 100%;
      height: auto;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-flex-direction: column;
      -moz-flex-direction: column;
      -ms-flex-direction: column;
      flex-direction: column; }
    .tuts-wrap__tuto {
      position: relative;
      overflow: hidden;
      height: 290px;
      margin: 20px 0; }
      .tuts-wrap__tuto p {
        font-size: 14px; }

  .figure__link span {
    color: black;
    font-weight: 400;
    text-transform: uppercase;
    font-size: 14px; }

  .contact {
    position: relative;
    width: 100%;
    height: auto;
    padding: 0 15px;
    padding-bottom: 40px; }
    .contact h3 {
      font-size: 20px;
      margin-top: 20px; }

  .contWrap {
    width: 100%;
    height: auto;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column; }
    .contWrap__box {
      width: 100%;
      margin: 20px 0; }
    .contWrap__iconBox {
      width: 100%;
      height: 100px; }
    .contWrap__link {
      width: 40px;
      height: 40px; }
    .contWrap__icon {
      font-size: 1.7em; }
    .contWrap__text {
      font-size: 15px; }
    .contWrap__boxForm {
      width: 100%; }
    .contWrap__form {
      width: 100%; }
    .contWrap__input {
      width: 100%; }
      .contWrap__input input {
        width: 100%;
        font-size: .9em; }
    .contWrap__mess {
      width: 100%;
      min-width: 100%;
      font-size: .9em; }
    .contWrap__button {
      width: 100%; }
    .contWrap__btn {
      width: 100%;
      font-size: .9em; }

  .footer {
    height: auto;
    padding: 0 15px; }
    .footer__wrap {
      width: 100%; }
    .footer__box {
      width: 100%;
      height: 800px;
      -webkit-flex-direction: column;
      -moz-flex-direction: column;
      -ms-flex-direction: column;
      flex-direction: column;
      -webkit-justify-content: space-evenly;
      -moz-justify-content: space-evenly;
      -ms-justify-content: space-evenly;
      justify-content: space-evenly;
      -ms-flex-pack: space-evenly;
      -webkit-align-items: center;
      -moz-align-items: center;
      -ms-align-items: center;
      align-items: center; }
    .footer__part {
      width: 100%;
      margin-bottom: 20px; }
      .footer__part:nth-child(4) {
        margin-bottom: 0; }
      .footer__part h4 {
        font-size: 17px;
        margin-bottom: 20px; }
      .footer__part li a {
        font-size: 15px; }

  .footer__part .fList--snd {
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column; }

  .copyright {
    position: relative;
    width: 100%;
    padding: 20px; }
    .copyright p {
      font-size: 16px; } }
/*End of media min-width: 320px nad max-width: 768px;*/
@media all and (min-width: 769px) and (max-width: 980px) {
  .main-nav {
    position: relative;
    width: 100%;
    height: 100px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center; }
    .main-nav__logoLinxBox {
      position: relative;
      width: 100%;
      height: 100px;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-align-items: center;
      -moz-align-items: center;
      -ms-align-items: center;
      align-items: center;
      -webkit-justify-content: space-between;
      -moz-justify-content: space-between;
      -ms-justify-content: space-between;
      justify-content: space-between;
      -ms-flex-pack: space-between; }
      .main-nav__logoLinxBox .linx {
        position: relative;
        width: 45%;
        display: -webkit-box;
        display: -moz-box;
        display: -ms-flexbox;
        display: -webkit-flex;
        display: flex;
        -webkit-justify-content: space-around;
        -moz-justify-content: space-around;
        -ms-justify-content: space-around;
        justify-content: space-around;
        -ms-flex-pack: space-around;
        -webkit-align-items: center;
        -moz-align-items: center;
        -ms-align-items: center;
        align-items: center;
        font-size: 1.5em; }
        .main-nav__logoLinxBox .linx__link--sliding-middle-out {
          display: inline-block;
          position: relative;
          padding-bottom: 3px; }
        .main-nav__logoLinxBox .linx__link--sliding-middle-out:after {
          content: '';
          display: block;
          margin: auto;
          height: 3px;
          width: 0px;
          background: transparent;
          transition: width .3s ease, background-color .3s ease; }
        .main-nav__logoLinxBox .linx__link--sliding-middle-out:hover:after {
          width: 100%;
          background: white; }
        .main-nav__logoLinxBox .linx a {
          color: #0F76A2; }
          .main-nav__logoLinxBox .linx a:visited {
            color: none; }
          .main-nav__logoLinxBox .linx a:hover {
            color: #23527c; }
        .main-nav__logoLinxBox .linx a {
          -webkit-transition: color 0.3s ease-in-out;
          -moz-transition: color 0.3s ease-in-out;
          -o-transition: color 0.3s ease-in-out;
          -ms-transition: color 0.3s ease-in-out;
          transition: color 0.3s ease-in-out; }

  .box_slider {
    width: 100%;
    height: 400px;
    margin-top: 60px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center; }
    .box_slider .slider {
      width: 80%;
      height: 400px;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-justify-content: center;
      -moz-justify-content: center;
      -ms-justify-content: center;
      justify-content: center;
      -ms-flex-pack: center;
      -webkit-align-items: center;
      -moz-align-items: center;
      -ms-align-items: center;
      align-items: center; }
      .box_slider .slider .slick-list {
        position: relative;
        display: block;
        overflow: hidden;
        margin: 0;
        padding: 0;
        text-align: center; }

  .box_slider div h1 {
    font-size: 4em;
    color: #0F76A2; }
  .box_slider div h3 {
    font-size: 26px;
    font-weight: 400;
    color: #0F76A2; }

  .discription {
    width: 100%;
    height: auto; }

  .dwrap {
    width: 100%;
    height: auto;
    background: #efefef;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center; }
    .dwrap__boxText {
      width: 80%;
      height: auto;
      margin-top: 40px;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-flex-direction: column;
      -moz-flex-direction: column;
      -ms-flex-direction: column;
      flex-direction: column;
      -webkit-justify-content: center;
      -moz-justify-content: center;
      -ms-justify-content: center;
      justify-content: center;
      -ms-flex-pack: center; }
      .dwrap__boxText h3 {
        font-size: 26px;
        margin-bottom: 20px; }
        .dwrap__boxText h3 span {
          color: #8c8c8c;
          font-weight: 200; }
      .dwrap__boxText p {
        color: #8c8c8c;
        line-height: 150%;
        font-size: 16px; }
        .dwrap__boxText p span {
          font-style: italic; }

  .features {
    width: 100%;
    height: auto;
    margin-bottom: 0;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center;
    padding: 0 15px; }
    .features h3 {
      font-size: 26px;
      margin-top: 40px; }
      .features h3 span {
        color: #8c8c8c;
        font-weight: 200; }

  .fFullBox {
    width: 100%;
    height: 500px;
    margin-top: 40px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column; }
    .fFullBox__box {
      width: 100%;
      margin-bottom: 40px;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-flex-direction: row;
      -moz-flex-direction: row;
      -ms-flex-direction: row;
      flex-direction: row; }

  .fFullBox__part {
    width: 40%;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex; }
  .fFullBox__icon {
    position: relative;
    width: 60px;
    height: 60px;
    margin-right: 10px; }
    .fFullBox__icon i {
      position: absolute;
      top: 0;
      left: 0;
      width: 100%;
      height: 100%;
      color: #b2dbbd;
      font-size: 2.6em; }
  .fFullBox__discrb {
    width: 100%; }
    .fFullBox__discrb h4 {
      margin-bottom: 10px;
      font-size: 22px;
      font-weight: bold; }
    .fFullBox__discrb p {
      font-size: 16px;
      color: #8c8c8c; }

  .tuts {
    position: relative;
    width: 100%;
    height: 550px;
    padding: 0 15px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: column;
    -moz-flex-direction: column;
    -ms-flex-direction: column;
    flex-direction: column;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center;
    background: #70c1b3;
    z-index: 1; }
    .tuts h3 {
      text-align: center;
      font-size: 26px;
      margin-top: 40px; }
      .tuts h3 span {
        color: #fff;
        font-weight: 200; }

  .tuts-wrap {
    width: 100%;
    height: 500px;
    padding-bottom: 40px;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: center;
    -moz-justify-content: center;
    -ms-justify-content: center;
    justify-content: center;
    -ms-flex-pack: center;
    -webkit-align-items: center;
    -moz-align-items: center;
    -ms-align-items: center;
    align-items: center; }
    .tuts-wrap__tutsBox {
      width: 100%;
      height: 400px;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-flex-direction: row;
      -moz-flex-direction: row;
      -ms-flex-direction: row;
      flex-direction: row;
      -webkit-justify-content: space-between;
      -moz-justify-content: space-between;
      -ms-justify-content: space-between;
      justify-content: space-between;
      -ms-flex-pack: space-between;
      -webkit-align-items: center;
      -moz-align-items: center;
      -ms-align-items: center;
      align-items: center; }

  .figure__link {
    position: absolute;
    top: 0;
    left: 0;
    z-index: 3;
    visibility: hidden;
    cursor: pointer;
    pointer-events: auto;
    border: 3px solid black;
    padding: 7px;
    -webkit-transform: translate(50%, 200%);
    -moz-transform: translate(50%, 200%);
    -ms-transform: translate(50%, 200%);
    -o-transform: translate(50%, 200%);
    transform: translate(50%, 200%); }
    .figure__link span {
      color: black;
      font-weight: 400;
      text-transform: uppercase; }

  .tuts-wrap__text {
    background: #eee;
    position: absolute;
    bottom: 0;
    z-index: 1;
    padding: 15px; }
    .tuts-wrap__text p {
      font-size: 13px; }

  .contact {
    position: relative;
    width: 100%;
    height: auto;
    padding: 0 15px;
    padding-bottom: 40px; }
    .contact h3 {
      font-size: 26px;
      margin: 40px 0; }

  .contWrap {
    width: 100%;
    height: auto;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex; }
    .contWrap__box {
      width: 100%;
      margin: 20px 0; }
    .contWrap__iconBox {
      width: 80%;
      height: 100px; }
    .contWrap__link {
      width: 40px;
      height: 40px; }
    .contWrap__icon {
      font-size: 2em; }
    .contWrap__text {
      font-size: 16px;
      width: 80%; }
    .contWrap__boxForm {
      width: 80%; }
    .contWrap__form {
      width: 100%; }
    .contWrap__input {
      width: 100%; }
      .contWrap__input input {
        width: 100%;
        font-size: .9em; }
    .contWrap__mess {
      width: 100%;
      min-width: 100%;
      font-size: .9em; }
    .contWrap__button {
      width: 100%; }
    .contWrap__btn {
      width: 100%;
      font-size: .9em; }

  .footer {
    height: auto;
    padding: 0 15px; }
    .footer__wrap {
      width: 100%; }
    .footer__box {
      width: 100%;
      height: 400px;
      display: -webkit-box;
      display: -moz-box;
      display: -ms-flexbox;
      display: -webkit-flex;
      display: flex;
      -webkit-justify-content: space-evenly;
      -moz-justify-content: space-evenly;
      -ms-justify-content: space-evenly;
      justify-content: space-evenly;
      -ms-flex-pack: space-evenly;
      -webkit-align-items: center;
      -moz-align-items: center;
      -ms-align-items: center;
      align-items: center; }
    .footer__part {
      width: 100%;
      margin-bottom: 0; }
      .footer__part:nth-child(4) {
        margin-bottom: 0; }
      .footer__part h4 {
        font-size: 17px;
        margin-bottom: 20px; }
      .footer__part li a {
        font-size: 15px; }

  .footer__part .fList--snd {
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-flex-direction: row;
    -moz-flex-direction: row;
    -ms-flex-direction: row;
    flex-direction: row;
    -webkit-justify-content: space-around;
    -moz-justify-content: space-around;
    -ms-justify-content: space-around;
    justify-content: space-around;
    -ms-flex-pack: space-around;
    -webkit-align-items: last baseline;
    -moz-align-items: last baseline;
    -ms-align-items: last baseline;
    align-items: last baseline; }
  .footer__part .fList--3th {
    width: 70%; }
    .footer__part .fList--3th li a i {
      font-size: 1.6em; }

  .copyright {
    position: relative;
    width: 100%;
    padding: 20px; }
    .copyright p {
      font-size: 16px; } }
@media all and (min-width: 980px) {
  .linx {
    position: relative;
    width: 45%;
    display: -webkit-box;
    display: -moz-box;
    display: -ms-flexbox;
    display: -webkit-flex;
    display: flex;
    -webkit-justify-content: space-between;
    -moz-justify-content: space-between;
    -ms-justify-content: space-between;
    justify-content: space-between;
    -ms-flex-pack: space-between;
    -webkit-align-items: flex-start;
    -moz-align-items: flex-start;
    -ms-align-items: flex-start;
    align-items: flex-start; }

  .main-nav__hamburger {
    display: none; }

  .wrap-tuts__tuto {
    width: 30%;
    height: 290px; } }

/*# sourceMappingURL=main.cs.map */
