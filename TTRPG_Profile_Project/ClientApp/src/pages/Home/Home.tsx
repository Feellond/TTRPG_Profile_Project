import { Card } from 'primereact/card';
import React from 'react';

const Home = () => {
    return (
        <Card style={{minHeight: '500px', margin: '0 auto' }} >
            <div className="w-full" style={{ marginTop: "-20px" }}>
                <div className="card block bg-bluegray-50">
                    <div className="flex flex-column text-0 m-2">
                        <h2>Добро пожаловать!</h2>
                        <span className='mb-1 ml-1'>Сайт является источником справочной информации по настольной игре Ведьмак.</span>
                        <span className='mb-1 ml-1'>Сайт не несет цели на объяснение правил, из-за чего вам необходимо обладать копией данной настольной игры.</span>
                        <span className='mb-1 ml-1'>Проект сделан на чистом энтузиазме и не является коммерческим продуктом.</span>
                        <span className='mb-1 ml-1'>Если вы обнаружили ошибки или у вас есть какие-то вопросы, вы можете писать на почту: feellond22@gmail.com</span>
                    </div>
                </div>
            </div>
        </Card>
    );
};

export default Home;