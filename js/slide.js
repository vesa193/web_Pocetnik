$(document).ready(function(){
  
  $('.slider').slick({
    adaptiveHeight: true,
  	dots: true,
  	touchMove: true,
  	arrows: false,
  	autoplay: true,
  });

//hamburger(menu)
function activeMenu() {
	var $hamb = $('.main-nav__hamburger');
	var $close = $('.main-nav__close');
	var $linx = $('.header .linx');
	var $nav = $('.main-nav');
	var $search = $('.search-btn');
	var $iconMenu  = $('.main-nav__icon-menu');

	$hamb.click(function(event) {
		if($linx.css('transform', 'translate(100%, 0)')) {
			$linx.css('transform', 'translate(0%, 0)');
			$hamb.css('display', 'none');
			$close.css('display', 'block');
			$iconMenu.addClass('animateIcon');
			//$search.css('display', 'block');
		} else {
			$linx.css('transform', 'translate(100%, 0)');
		}
	
		//$nav.addClass('bgdNav');
	});
	$close.click(function(event) {
		if($linx.css('transform', 'translate(0%, 0)')) {
			$linx.css('transform', 'translate(100%, 0)');
			$hamb.css('display', 'block');
			$close.css('display', 'none');
			$iconMenu.removeClass('animateIcon');
		} else {
			$linx.css('transform', 'translate(100%, 0)');
		}
	
		//$nav.removeClass('bgdNav');	
	});
};
activeMenu();

//searching
	
	function searching() {
		var $search = $('.search-btn');
		var $input = $('.input');
		var $close = $('.form-search__close');
		var $formSrch = $('.form-search');

		$search.click(function(){
			$formSrch.toggleClass('active');
			$input.css({
				'display': '-webkit-box',
				'display': '-moz-box',
				'display': '-ms-flexbox',
				'display': '-webkit-flex',
				'display': 'flex'
			}).focus();
			$close.css({
				'display': '-webkit-box',
				'display': '-moz-box',
				'display': '-ms-flexbox',
				'display': '-webkit-flex',
				'display': 'flex'
			});
		});

		$close.click(function(){
			$formSrch.toggleClass('active');
		});
	} 
	searching();
	// Settings for hamburger
	

	//settings for search-btn 
	function searchBtn() {
		var $hamb = $('.main-nav__hamburger');
		var $search = $('.search-btn');
		var $close = $('.main-nav__close');

		$hamb.click(function(event) {
			$search.css({
				'display': '-webkit-box',
				'display': '-moz-box',
				'display': '-ms-flexbox',
				'display': '-webkit-flex',
				'display': 'flex'
			}).fadeIn(400);		
		});

		$close.click(function(event) {
			$search.css({
				'display': 'none'
			}).fadeOut(400);		
		});

	}
	searchBtn();

	//settings for animation on scroll for main-nav 

	function scrollNav() {
		$(window).bind('scroll', function () {
		    var $menu = $('.main-nav');
		    if ($(window).scrollTop() >= $('.slider').offset().top) {
		        $menu.css({
		        	'background': '#042c3c',
		        	'position': 'sticky',
		        	'z-index': '55'
		        });
		    } else {
		        $menu.css({
		        	'background': 'transparent',
		        	'position': 'relative'
		        });
		    }
		});
	}
	scrollNav();
	//settings for cards

	/*function cards() {
		$('.about__card').mouseover(function(event) {
			$('.about__card__mask').css({
				'display': 'block'
			});
		});
	}
	cards();*/
});
