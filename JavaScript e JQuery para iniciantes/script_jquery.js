/* $(function(){
    $('#azul').click(function(){
        $('p').css("background-color", "blue");
        $('p').fadeOut();
    });

    $('#vermelho').click(function(){
        $('p').css("background-color", "red");
        $('#mensagem').text('cor alterada com sucesso')
        .css({color: 'red', border: '1px solid red', padding: '10px'})
        .addClass('cor');
        
        $('#vermelho').removeClass('red');
    })
}) */

    $(function(){

        $('#l1').click(function(){
            $('#i2').hide();
            $('#i3').hide();
            $('#i4').hide();
            $('#i1').show();


        }
    );

        $('#l2').click(function(){
            $('#i1').hide();
            $('#i3').hide();
            $('#i4').hide();
            $('#i2').show();


        }
    );

        $('#l3').click(function(){
            $('#i1').hide();
            $('#i2').hide();
            $('#i4').hide();
            $('#i3').show();


        }
    );

        $('#l4').click(function(){
            $('#i1').hide();
            $('#i2').hide();
            $('#i3').hide();
            $('#i4').show();


        }
    );
}
)