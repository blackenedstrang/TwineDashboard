//TODO: do it much more nicely and in OOP way

bootstrap_alert = function () { };
bootstrap_alert.attention = function (message, placeholder) {
	$(placeholder).prepend('<div class="alert alert-attention"><button type="button" class="close" data-dismiss="alert">x</button>' + message + '</div>');
};